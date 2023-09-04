using static System.Console;

public class Program{

    static void Main(){
        HogwartsStudent[] hogwartsStudents = {
            new HogwartsStudentCallan(),
            new HogwartsStudentErin(),
            new HogwartsStudentJacob(),
            new HogwartsStudentSumen()
        };

        foreach(HogwartsStudent s in hogwartsStudents){
            WriteLine(s);
        }
    }

}