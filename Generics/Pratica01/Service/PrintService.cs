namespace Pratica01.Service
{
    public class PrintService <T>
    {
        // Inicialmente esta classe lia apenas números inteiros, mas quero tornar o código reusável
       
       private T[] _Values = new T[10];
       private int _Count = 0; // Anda pelo o vetor

       public void AddValue(T value){
        if(_Count == 10){
            throw new InvalidOperationException("PrintService is full.");
        }
        _Values[_Count] = value;
        _Count ++;
       }

       public T First(){
        if(_Count == 0){
            throw new InvalidOperationException("PrintService is empty.");
        }

        return _Values[0];
       }

       public void Print(){
        Console.Write("[");
        for(int i = 0; i < _Count - 1; i++)
        {
            Console.Write(_Values[i] + ", ");
        }
        if(_Count > 0)
        {
            Console.Write(_Values[_Count - 1 ]);
        }
        Console.Write("]");
       }
    }
}