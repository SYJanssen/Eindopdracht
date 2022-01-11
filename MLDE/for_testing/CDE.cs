/*
* MATLAB Compiler: 8.3 (R2021b)
* Date: Tue Jan 11 15:03:24 2022
* Arguments:
* "-B""macro_default""-W""dotnet:MLDE,CDE,4.0,private,version=1.0""-T""link:lib""-d""D:\TW
* \Scientific
* computing\Opdrachten\Eindopdracht\MLDE\for_testing""-v""class{CDE:D:\TW\MATLAB
* drive\Eindopdracht_SC\DE.m}"
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace MLDE
{

  /// <summary>
  /// The CDE class provides a CLS compliant, MWArray interface to the MATLAB functions
  /// contained in the files:
  /// <newpara></newpara>
  /// D:\TW\MATLAB drive\Eindopdracht_SC\DE.m
  /// </summary>
  /// <remarks>
  /// @Version 1.0
  /// </remarks>
  public class CDE : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Runtime instance.
    /// </summary>
    static CDE()
    {
      if (MWMCR.MCRAppInitialized)
      {
        try
        {
          Assembly assembly= Assembly.GetExecutingAssembly();

          string ctfFilePath= assembly.Location;

		  int lastDelimiter = ctfFilePath.LastIndexOf(@"/");

	      if (lastDelimiter == -1)
		  {
		    lastDelimiter = ctfFilePath.LastIndexOf(@"\");
		  }

          ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

          string ctfFileName = "MLDE.ctf";

          Stream embeddedCtfStream = null;

          String[] resourceStrings = assembly.GetManifestResourceNames();

          foreach (String name in resourceStrings)
          {
            if (name.Contains(ctfFileName))
            {
              embeddedCtfStream = assembly.GetManifestResourceStream(name);
              break;
            }
          }
          mcr= new MWMCR("",
                         ctfFilePath, embeddedCtfStream, true);
        }
        catch(Exception ex)
        {
          ex_ = new Exception("MWArray assembly failed to be initialized", ex);
        }
      }
      else
      {
        ex_ = new ApplicationException("MWArray assembly could not be initialized");
      }
    }


    /// <summary>
    /// Constructs a new instance of the CDE class.
    /// </summary>
    public CDE()
    {
      if(ex_ != null)
      {
        throw ex_;
      }
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~CDE()
    {
      Dispose(false);
    }


    /// <summary>
    /// Frees the native resources associated with this object
    /// </summary>
    public void Dispose()
    {
      Dispose(true);

      GC.SuppressFinalize(this);
    }


    /// <summary internal= "true">
    /// Internal dispose function
    /// </summary>
    protected virtual void Dispose(bool disposing)
    {
      if (!disposed)
      {
        disposed= true;

        if (disposing)
        {
          // Free managed resources;
        }

        // Free native resources
      }
    }


    #endregion Finalize

    #region Methods

    /// <summary>
    /// Provides a void output, 0-input MWArrayinterface to the DE MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Parameters
    /// </remarks>
    ///
    public void DE()
    {
      mcr.EvaluateFunction(0, "DE", new MWArray[]{});
    }


    /// <summary>
    /// Provides a void output, 1-input MWArrayinterface to the DE MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Parameters
    /// </remarks>
    /// <param name="metaal">Input argument #1</param>
    ///
    public void DE(MWArray metaal)
    {
      mcr.EvaluateFunction(0, "DE", metaal);
    }


    /// <summary>
    /// Provides a void output, 2-input MWArrayinterface to the DE MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Parameters
    /// </remarks>
    /// <param name="metaal">Input argument #1</param>
    /// <param name="L1">Input argument #2</param>
    ///
    public void DE(MWArray metaal, MWArray L1)
    {
      mcr.EvaluateFunction(0, "DE", metaal, L1);
    }


    /// <summary>
    /// Provides a void output, 3-input MWArrayinterface to the DE MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Parameters
    /// </remarks>
    /// <param name="metaal">Input argument #1</param>
    /// <param name="L1">Input argument #2</param>
    /// <param name="L2">Input argument #3</param>
    ///
    public void DE(MWArray metaal, MWArray L1, MWArray L2)
    {
      mcr.EvaluateFunction(0, "DE", metaal, L1, L2);
    }


    /// <summary>
    /// Provides a void output, 4-input MWArrayinterface to the DE MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Parameters
    /// </remarks>
    /// <param name="metaal">Input argument #1</param>
    /// <param name="L1">Input argument #2</param>
    /// <param name="L2">Input argument #3</param>
    /// <param name="T1">Input argument #4</param>
    ///
    public void DE(MWArray metaal, MWArray L1, MWArray L2, MWArray T1)
    {
      mcr.EvaluateFunction(0, "DE", metaal, L1, L2, T1);
    }


    /// <summary>
    /// Provides a void output, 5-input MWArrayinterface to the DE MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Parameters
    /// </remarks>
    /// <param name="metaal">Input argument #1</param>
    /// <param name="L1">Input argument #2</param>
    /// <param name="L2">Input argument #3</param>
    /// <param name="T1">Input argument #4</param>
    /// <param name="T2">Input argument #5</param>
    ///
    public void DE(MWArray metaal, MWArray L1, MWArray L2, MWArray T1, MWArray T2)
    {
      mcr.EvaluateFunction(0, "DE", metaal, L1, L2, T1, T2);
    }


    /// <summary>
    /// Provides a void output, 6-input MWArrayinterface to the DE MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Parameters
    /// </remarks>
    /// <param name="metaal">Input argument #1</param>
    /// <param name="L1">Input argument #2</param>
    /// <param name="L2">Input argument #3</param>
    /// <param name="T1">Input argument #4</param>
    /// <param name="T2">Input argument #5</param>
    /// <param name="profiel">Input argument #6</param>
    ///
    public void DE(MWArray metaal, MWArray L1, MWArray L2, MWArray T1, MWArray T2, 
             MWArray profiel)
    {
      mcr.EvaluateFunction(0, "DE", metaal, L1, L2, T1, T2, profiel);
    }


    /// <summary>
    /// Provides a void output, 7-input MWArrayinterface to the DE MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Parameters
    /// </remarks>
    /// <param name="metaal">Input argument #1</param>
    /// <param name="L1">Input argument #2</param>
    /// <param name="L2">Input argument #3</param>
    /// <param name="T1">Input argument #4</param>
    /// <param name="T2">Input argument #5</param>
    /// <param name="profiel">Input argument #6</param>
    /// <param name="n">Input argument #7</param>
    ///
    public void DE(MWArray metaal, MWArray L1, MWArray L2, MWArray T1, MWArray T2, 
             MWArray profiel, MWArray n)
    {
      mcr.EvaluateFunction(0, "DE", metaal, L1, L2, T1, T2, profiel, n);
    }


    /// <summary>
    /// Provides a void output, 8-input MWArrayinterface to the DE MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Parameters
    /// </remarks>
    /// <param name="metaal">Input argument #1</param>
    /// <param name="L1">Input argument #2</param>
    /// <param name="L2">Input argument #3</param>
    /// <param name="T1">Input argument #4</param>
    /// <param name="T2">Input argument #5</param>
    /// <param name="profiel">Input argument #6</param>
    /// <param name="n">Input argument #7</param>
    /// <param name="m">Input argument #8</param>
    ///
    public void DE(MWArray metaal, MWArray L1, MWArray L2, MWArray T1, MWArray T2, 
             MWArray profiel, MWArray n, MWArray m)
    {
      mcr.EvaluateFunction(0, "DE", metaal, L1, L2, T1, T2, profiel, n, m);
    }


    /// <summary>
    /// Provides a void output, 9-input MWArrayinterface to the DE MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Parameters
    /// </remarks>
    /// <param name="metaal">Input argument #1</param>
    /// <param name="L1">Input argument #2</param>
    /// <param name="L2">Input argument #3</param>
    /// <param name="T1">Input argument #4</param>
    /// <param name="T2">Input argument #5</param>
    /// <param name="profiel">Input argument #6</param>
    /// <param name="n">Input argument #7</param>
    /// <param name="m">Input argument #8</param>
    /// <param name="prof_constant">Input argument #9</param>
    ///
    public void DE(MWArray metaal, MWArray L1, MWArray L2, MWArray T1, MWArray T2, 
             MWArray profiel, MWArray n, MWArray m, MWArray prof_constant)
    {
      mcr.EvaluateFunction(0, "DE", metaal, L1, L2, T1, T2, profiel, n, m, prof_constant);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the DE MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Parameters
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] DE(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "DE", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the DE MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Parameters
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="metaal">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] DE(int numArgsOut, MWArray metaal)
    {
      return mcr.EvaluateFunction(numArgsOut, "DE", metaal);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the DE MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Parameters
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="metaal">Input argument #1</param>
    /// <param name="L1">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] DE(int numArgsOut, MWArray metaal, MWArray L1)
    {
      return mcr.EvaluateFunction(numArgsOut, "DE", metaal, L1);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the DE MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Parameters
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="metaal">Input argument #1</param>
    /// <param name="L1">Input argument #2</param>
    /// <param name="L2">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] DE(int numArgsOut, MWArray metaal, MWArray L1, MWArray L2)
    {
      return mcr.EvaluateFunction(numArgsOut, "DE", metaal, L1, L2);
    }


    /// <summary>
    /// Provides the standard 4-input MWArray interface to the DE MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Parameters
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="metaal">Input argument #1</param>
    /// <param name="L1">Input argument #2</param>
    /// <param name="L2">Input argument #3</param>
    /// <param name="T1">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] DE(int numArgsOut, MWArray metaal, MWArray L1, MWArray L2, MWArray 
                  T1)
    {
      return mcr.EvaluateFunction(numArgsOut, "DE", metaal, L1, L2, T1);
    }


    /// <summary>
    /// Provides the standard 5-input MWArray interface to the DE MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Parameters
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="metaal">Input argument #1</param>
    /// <param name="L1">Input argument #2</param>
    /// <param name="L2">Input argument #3</param>
    /// <param name="T1">Input argument #4</param>
    /// <param name="T2">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] DE(int numArgsOut, MWArray metaal, MWArray L1, MWArray L2, MWArray 
                  T1, MWArray T2)
    {
      return mcr.EvaluateFunction(numArgsOut, "DE", metaal, L1, L2, T1, T2);
    }


    /// <summary>
    /// Provides the standard 6-input MWArray interface to the DE MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Parameters
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="metaal">Input argument #1</param>
    /// <param name="L1">Input argument #2</param>
    /// <param name="L2">Input argument #3</param>
    /// <param name="T1">Input argument #4</param>
    /// <param name="T2">Input argument #5</param>
    /// <param name="profiel">Input argument #6</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] DE(int numArgsOut, MWArray metaal, MWArray L1, MWArray L2, MWArray 
                  T1, MWArray T2, MWArray profiel)
    {
      return mcr.EvaluateFunction(numArgsOut, "DE", metaal, L1, L2, T1, T2, profiel);
    }


    /// <summary>
    /// Provides the standard 7-input MWArray interface to the DE MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Parameters
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="metaal">Input argument #1</param>
    /// <param name="L1">Input argument #2</param>
    /// <param name="L2">Input argument #3</param>
    /// <param name="T1">Input argument #4</param>
    /// <param name="T2">Input argument #5</param>
    /// <param name="profiel">Input argument #6</param>
    /// <param name="n">Input argument #7</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] DE(int numArgsOut, MWArray metaal, MWArray L1, MWArray L2, MWArray 
                  T1, MWArray T2, MWArray profiel, MWArray n)
    {
      return mcr.EvaluateFunction(numArgsOut, "DE", metaal, L1, L2, T1, T2, profiel, n);
    }


    /// <summary>
    /// Provides the standard 8-input MWArray interface to the DE MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Parameters
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="metaal">Input argument #1</param>
    /// <param name="L1">Input argument #2</param>
    /// <param name="L2">Input argument #3</param>
    /// <param name="T1">Input argument #4</param>
    /// <param name="T2">Input argument #5</param>
    /// <param name="profiel">Input argument #6</param>
    /// <param name="n">Input argument #7</param>
    /// <param name="m">Input argument #8</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] DE(int numArgsOut, MWArray metaal, MWArray L1, MWArray L2, MWArray 
                  T1, MWArray T2, MWArray profiel, MWArray n, MWArray m)
    {
      return mcr.EvaluateFunction(numArgsOut, "DE", metaal, L1, L2, T1, T2, profiel, n, m);
    }


    /// <summary>
    /// Provides the standard 9-input MWArray interface to the DE MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Parameters
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="metaal">Input argument #1</param>
    /// <param name="L1">Input argument #2</param>
    /// <param name="L2">Input argument #3</param>
    /// <param name="T1">Input argument #4</param>
    /// <param name="T2">Input argument #5</param>
    /// <param name="profiel">Input argument #6</param>
    /// <param name="n">Input argument #7</param>
    /// <param name="m">Input argument #8</param>
    /// <param name="prof_constant">Input argument #9</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] DE(int numArgsOut, MWArray metaal, MWArray L1, MWArray L2, MWArray 
                  T1, MWArray T2, MWArray profiel, MWArray n, MWArray m, MWArray 
                  prof_constant)
    {
      return mcr.EvaluateFunction(numArgsOut, "DE", metaal, L1, L2, T1, T2, profiel, n, m, prof_constant);
    }



    /// <summary>
    /// This method will cause a MATLAB figure window to behave as a modal dialog box.
    /// The method will not return until all the figure windows associated with this
    /// component have been closed.
    /// </summary>
    /// <remarks>
    /// An application should only call this method when required to keep the
    /// MATLAB figure window from disappearing.  Other techniques, such as calling
    /// Console.ReadLine() from the application should be considered where
    /// possible.</remarks>
    ///
    public void WaitForFiguresToDie()
    {
      mcr.WaitForFiguresToDie();
    }



    #endregion Methods

    #region Class Members

    private static MWMCR mcr= null;

    private static Exception ex_= null;

    private bool disposed= false;

    #endregion Class Members
  }
}
