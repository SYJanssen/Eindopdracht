/*
* MATLAB Compiler: 8.3 (R2021b)
* Date: Tue Jan 11 15:44:35 2022
* Arguments:
* "-B""macro_default""-W""dotnet:MLDE2,CDE2,4.0,private,version=1.0""-T""link:lib""-d""D:\
* TW\MATLAB drive\Eindopdracht_SC\MLDE2\for_testing""-v""class{CDE2:D:\TW\MATLAB
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

namespace MLDE2Native
{

  /// <summary>
  /// The CDE2 class provides a CLS compliant, Object (native) interface to the MATLAB
  /// functions contained in the files:
  /// <newpara></newpara>
  /// D:\TW\MATLAB drive\Eindopdracht_SC\DE.m
  /// </summary>
  /// <remarks>
  /// @Version 1.0
  /// </remarks>
  public class CDE2 : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Runtime instance.
    /// </summary>
    static CDE2()
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

          string ctfFileName = "MLDE2.ctf";

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
    /// Constructs a new instance of the CDE2 class.
    /// </summary>
    public CDE2()
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
    ~CDE2()
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
    /// Provides a single output, 0-input Objectinterface to the DE MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Parameters
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object DE()
    {
      return mcr.EvaluateFunction("DE", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the DE MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Parameters
    /// </remarks>
    /// <param name="metaal">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object DE(Object metaal)
    {
      return mcr.EvaluateFunction("DE", metaal);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the DE MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Parameters
    /// </remarks>
    /// <param name="metaal">Input argument #1</param>
    /// <param name="L1">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object DE(Object metaal, Object L1)
    {
      return mcr.EvaluateFunction("DE", metaal, L1);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the DE MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Parameters
    /// </remarks>
    /// <param name="metaal">Input argument #1</param>
    /// <param name="L1">Input argument #2</param>
    /// <param name="L2">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object DE(Object metaal, Object L1, Object L2)
    {
      return mcr.EvaluateFunction("DE", metaal, L1, L2);
    }


    /// <summary>
    /// Provides a single output, 4-input Objectinterface to the DE MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Parameters
    /// </remarks>
    /// <param name="metaal">Input argument #1</param>
    /// <param name="L1">Input argument #2</param>
    /// <param name="L2">Input argument #3</param>
    /// <param name="T1">Input argument #4</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object DE(Object metaal, Object L1, Object L2, Object T1)
    {
      return mcr.EvaluateFunction("DE", metaal, L1, L2, T1);
    }


    /// <summary>
    /// Provides a single output, 5-input Objectinterface to the DE MATLAB function.
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
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object DE(Object metaal, Object L1, Object L2, Object T1, Object T2)
    {
      return mcr.EvaluateFunction("DE", metaal, L1, L2, T1, T2);
    }


    /// <summary>
    /// Provides a single output, 6-input Objectinterface to the DE MATLAB function.
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
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object DE(Object metaal, Object L1, Object L2, Object T1, Object T2, Object 
               profiel)
    {
      return mcr.EvaluateFunction("DE", metaal, L1, L2, T1, T2, profiel);
    }


    /// <summary>
    /// Provides a single output, 7-input Objectinterface to the DE MATLAB function.
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
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object DE(Object metaal, Object L1, Object L2, Object T1, Object T2, Object 
               profiel, Object n)
    {
      return mcr.EvaluateFunction("DE", metaal, L1, L2, T1, T2, profiel, n);
    }


    /// <summary>
    /// Provides a single output, 8-input Objectinterface to the DE MATLAB function.
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
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object DE(Object metaal, Object L1, Object L2, Object T1, Object T2, Object 
               profiel, Object n, Object m)
    {
      return mcr.EvaluateFunction("DE", metaal, L1, L2, T1, T2, profiel, n, m);
    }


    /// <summary>
    /// Provides a single output, 9-input Objectinterface to the DE MATLAB function.
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
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object DE(Object metaal, Object L1, Object L2, Object T1, Object T2, Object 
               profiel, Object n, Object m, Object prof_constant)
    {
      return mcr.EvaluateFunction("DE", metaal, L1, L2, T1, T2, profiel, n, m, prof_constant);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the DE MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Parameters
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] DE(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "DE", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the DE MATLAB function.
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
    public Object[] DE(int numArgsOut, Object metaal)
    {
      return mcr.EvaluateFunction(numArgsOut, "DE", metaal);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the DE MATLAB function.
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
    public Object[] DE(int numArgsOut, Object metaal, Object L1)
    {
      return mcr.EvaluateFunction(numArgsOut, "DE", metaal, L1);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the DE MATLAB function.
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
    public Object[] DE(int numArgsOut, Object metaal, Object L1, Object L2)
    {
      return mcr.EvaluateFunction(numArgsOut, "DE", metaal, L1, L2);
    }


    /// <summary>
    /// Provides the standard 4-input Object interface to the DE MATLAB function.
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
    public Object[] DE(int numArgsOut, Object metaal, Object L1, Object L2, Object T1)
    {
      return mcr.EvaluateFunction(numArgsOut, "DE", metaal, L1, L2, T1);
    }


    /// <summary>
    /// Provides the standard 5-input Object interface to the DE MATLAB function.
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
    public Object[] DE(int numArgsOut, Object metaal, Object L1, Object L2, Object T1, 
                 Object T2)
    {
      return mcr.EvaluateFunction(numArgsOut, "DE", metaal, L1, L2, T1, T2);
    }


    /// <summary>
    /// Provides the standard 6-input Object interface to the DE MATLAB function.
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
    public Object[] DE(int numArgsOut, Object metaal, Object L1, Object L2, Object T1, 
                 Object T2, Object profiel)
    {
      return mcr.EvaluateFunction(numArgsOut, "DE", metaal, L1, L2, T1, T2, profiel);
    }


    /// <summary>
    /// Provides the standard 7-input Object interface to the DE MATLAB function.
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
    public Object[] DE(int numArgsOut, Object metaal, Object L1, Object L2, Object T1, 
                 Object T2, Object profiel, Object n)
    {
      return mcr.EvaluateFunction(numArgsOut, "DE", metaal, L1, L2, T1, T2, profiel, n);
    }


    /// <summary>
    /// Provides the standard 8-input Object interface to the DE MATLAB function.
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
    public Object[] DE(int numArgsOut, Object metaal, Object L1, Object L2, Object T1, 
                 Object T2, Object profiel, Object n, Object m)
    {
      return mcr.EvaluateFunction(numArgsOut, "DE", metaal, L1, L2, T1, T2, profiel, n, m);
    }


    /// <summary>
    /// Provides the standard 9-input Object interface to the DE MATLAB function.
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
    public Object[] DE(int numArgsOut, Object metaal, Object L1, Object L2, Object T1, 
                 Object T2, Object profiel, Object n, Object m, Object prof_constant)
    {
      return mcr.EvaluateFunction(numArgsOut, "DE", metaal, L1, L2, T1, T2, profiel, n, m, prof_constant);
    }


    /// <summary>
    /// Provides an interface for the DE function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// Parameters
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("DE", 9, 1, 0)]
    protected void DE(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("DE", numArgsOut, ref argsOut, argsIn, varArgsIn);
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
