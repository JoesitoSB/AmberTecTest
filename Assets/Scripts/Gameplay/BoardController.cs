using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardController : MonoBehaviour
{
    [SerializeField] private Camera mainCamera = null;

    [SerializeField] [Range(1, 10)] private int rowAmount = 1;
    [SerializeField] [Range(5, 10)] private int columnsAmount = 5;

    [SerializeField] private GameObject firstTowerBP = null;
    [SerializeField] private GameObject normalTowerBP = null;
    [SerializeField] private GameObject limitTowerBP = null;
    [SerializeField] private GameObject normalBP = null;
    [SerializeField] private GameObject enemySpawnerBP = null;

    private delegate void ShowAvailablePlaces(bool show);
    private ShowAvailablePlaces showAvailablePlaces;

    private BaseBoardPiece[,] board;


    private void Awake()
    {
        CreateBoard();
    }

    private void CreateBoard()
    {
        board = new BaseBoardPiece[rowAmount, columnsAmount];
        
        for(int i = 0; i < rowAmount; i++)
        {
            var topLeftCornerPos = new Vector2(0, Screen.height);

            // This time simply stay at the current distance to camera
            //transform.position = 

            var pos = mainCamera.ScreenToWorldPoint(new Vector3(topLeftCornerPos.x, topLeftCornerPos.y, Vector3.Distance(mainCamera.transform.position, transform.position)));
            if (i != 0)
            {
                pos = new Vector2(board[i - 1, 0].gameObject.transform.position.x,
                                    board[i - 1, 0].transform.position.y - board[i - 1, 0].GetSize().y);//TODO: FIX
            }

            //Here always goes first tower board piece
            var bBP = Instantiate(firstTowerBP, pos, Quaternion.identity, transform).GetComponent<BaseBoardPiece>();
            board[i, 0] = bBP;
            var baseTowerBoardPiece = ((BaseTowerBoardPiece)bBP);
            baseTowerBoardPiece.Init(this);
            showAvailablePlaces += baseTowerBoardPiece.ShowCanvas;
            
            for(int j = 1; j < columnsAmount; j++)
            {
                pos = new Vector2(board[i, j - 1].transform.position.x + board[i, j - 1].GetSize().x,
                                    board[i, j - 1].transform.position.y);
                if (j < columnsAmount / 2) // Set normal tower board pieces
                {                   
                    bBP = Instantiate(normalTowerBP, pos, Quaternion.identity, transform).GetComponent<BaseBoardPiece>();
                    board[i, j] = bBP;
                    baseTowerBoardPiece = ((BaseTowerBoardPiece)bBP);
                    baseTowerBoardPiece.Init(this);
                    showAvailablePlaces += baseTowerBoardPiece.ShowCanvas;
                }
                else if(j == columnsAmount / 2)
                {
                    bBP = Instantiate(limitTowerBP, pos, Quaternion.identity, transform).GetComponent<BaseBoardPiece>();
                    board[i, j] = bBP;
                    baseTowerBoardPiece = ((BaseTowerBoardPiece)bBP);
                    baseTowerBoardPiece.Init(this);
                    showAvailablePlaces += baseTowerBoardPiece.ShowCanvas;
                }
                else if (j == columnsAmount - 1)
                {
                    bBP = Instantiate(enemySpawnerBP, pos, Quaternion.identity, transform).GetComponent<BaseBoardPiece>();
                    board[i, j] = bBP;
                }
                else
                {
                    bBP = Instantiate(normalBP, pos, Quaternion.identity, transform).GetComponent<BaseBoardPiece>();
                    board[i, j] = bBP;
                }
            }
        }
    }

    public void ShowAvailableBoardPlaces(bool show)
    {
        /*for(int i = 0; i < rowAmount; i++)
        {
            for(int j = 0; j < columnsAmount / 2; j++) // just half because just the half of the columns are able to have towers in it
            {
                var bTB= (BaseTowerBoardPiece) board[i, j];
                bTB.ShowCanvas(true);
            }
        }*/
        showAvailablePlaces?.Invoke(show);
    }

}
