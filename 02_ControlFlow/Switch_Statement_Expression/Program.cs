namespace Switch_Statement_Expression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nummer = 2;
            //string melding;

            //switch (nummer)
            //{
            //    case 1:
            //        melding = "Een";
            //        break;
            //    case 2:
            //        melding = "Twee";
            //        break;
            //    case 3:
            //        melding = "Drie";
            //        break;
            //    default:
            //        melding = "Ongeldig nummer";
            //        break;
            //}

            //Console.WriteLine(melding);

            string melding = nummer switch
            {
                1 => "Een",
                2 => "Twee",
                3 => "Drie",
                _ => "Ongeldig nummer",
            };
            Console.WriteLine(melding);



            //string color = "Blue";
            //string hexValue;

            //switch (color)
            //{
            //    case "Red":
            //        hexValue = "#FF0000";
            //        break;
            //    case "Green":
            //        hexValue = "#00FF00";
            //        break;
            //    case "Blue":
            //        hexValue = "#0000FF";
            //        break;
            //    default:
            //        hexValue = "#FFFFFF";
            //        break;
            //};

            //Console.WriteLine(hexValue);

            string color = "Blue";
            string hexValue  = color switch
            {
                "#FF0000" => "Red",
                "#00FF00" => "Green",
                "#0000FF" => "Blue",
                _ => "#FFFFFF",
            };



            DayOfWeek dag = DayOfWeek.Monday;
            string actie; 

            switch (dag)
            {
                case DayOfWeek.Monday or 
                DayOfWeek.Tuesday or 
                DayOfWeek.Wednesday or 
                DayOfWeek.Thursday or 
                DayOfWeek.Friday:
                    actie = "Weekdag";
                    break;
                case DayOfWeek.Saturday or DayOfWeek.Sunday:
                    actie = "Weekend";
                    break;
                default:
                    actie = "Ongeldige dag";
                    break;
            }

            string Actie = dag switch
            {
                DayOfWeek.Monday or DayOfWeek.Tuesday or DayOfWeek.Wednesday or
                DayOfWeek.Thursday or
                DayOfWeek.Friday
                => Actie = "Weekdag",
                DayOfWeek.Saturday or DayOfWeek.Sunday => Actie = "Weekend",
                _ => Actie = "Ongeldige dag"
            };
        }
    }
}
