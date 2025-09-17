int [] sudoku = [9,9];

bool row_check = false;
bool column_check = false;
bool grid_check = false;

//jeg stinker
for (int i=0; i<9; i++){
    bool[] duplicate = bool[9];
    for(int j = 0; j<9; j++){
        int num = sudoku[i,j];
        if (num <1 || >9)
            duplicate = true;
        }
        if(duplicate[num-1]){
            duplicate = true
        }
        duplicate[num-1] = false;
    }

Console.WriteLine(sudoku[0,0]);
