namespace Karan

module FindPi =
    let rec atan x = function
        | 0 -> 0.
        | n -> System.Math.Pow (-1., float (n-1)) * System.Math.Pow (x, float (2*n-1)) / float(2*n-1) + atan x (n-1) 
        
    let calcPiDigits n = 16. * atan (1./5.) n - 4. * atan (1./239.) n
    

