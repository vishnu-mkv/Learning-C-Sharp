public class PayCalculator
{
    public static string Calculate(double[] arr)
    {
        double regularPay = 0.0;
        double overtimePay = 0.0;

        if (arr[1] > 17)
        {
            regularPay = (17 - arr[0]) * arr[2];
            overtimePay = (arr[1] - 17) * arr[2] * arr[3];
        }
        else
        {
            regularPay = (arr[1] - arr[0]) * arr[2];
        }

        double totalPay = regularPay + overtimePay;
        return "$" + Math.Round(totalPay, 2).ToString("F2");
    }

}