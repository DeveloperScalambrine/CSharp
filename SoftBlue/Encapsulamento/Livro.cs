namespace CSharp 
{
  public class Livro
  {
    public int NumPage { get; set; }
    public string Title { get; set; }
    public double Price { get; set; }
    public static int MaxPages { get; set; }   

    public Livro()
    {
      MaxPages = 500;
    }

        public override string ToString()
        {
            return $"My book cost {Price} The title is {Title} I am in the page {NumPage} about total of the {MaxPages} max pages";
        }
    }
}
