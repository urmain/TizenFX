#pragma warning disable CS1591
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
namespace Efl { 
/// <summary>Efl interpolator interface</summary>
[IInterpolatorNativeInherit]
public interface IInterpolator : 
    Efl.Eo.IWrapper, IDisposable
{
    /// <summary>Interpolate the given value.</summary>
/// <param name="progress">Input value mapped from 0.0 to 1.0.</param>
/// <returns>Output value calculated by interpolating the input value.</returns>
double Interpolate( double progress);
    }
/// <summary>Efl interpolator interface</summary>
sealed public class IInterpolatorConcrete : 

IInterpolator
    
{
    ///<summary>Pointer to the native class description.</summary>
    public System.IntPtr NativeClass {
        get {
            if (((object)this).GetType() == typeof (IInterpolatorConcrete))
                return Efl.IInterpolatorNativeInherit.GetEflClassStatic();
            else
                return Efl.Eo.ClassRegister.klassFromType[((object)this).GetType()];
        }
    }
    private  System.IntPtr handle;
    ///<summary>Pointer to the native instance.</summary>
    public System.IntPtr NativeHandle {
        get { return handle; }
    }
    [System.Runtime.InteropServices.DllImport(efl.Libs.Efl)] internal static extern System.IntPtr
        efl_interpolator_interface_get();
    ///<summary>Internal usage: Constructs an instance from a native pointer. This is used when interacting with C code and should not be used directly.</summary>
    private IInterpolatorConcrete(System.IntPtr raw)
    {
        handle = raw;
        RegisterEventProxies();
    }
    ///<summary>Destructor.</summary>
    ~IInterpolatorConcrete()
    {
        Dispose(false);
    }
    ///<summary>Releases the underlying native instance.</summary>
    void Dispose(bool disposing)
    {
        if (handle != System.IntPtr.Zero) {
            Efl.Eo.Globals.efl_unref(handle);
            handle = System.IntPtr.Zero;
        }
    }
    ///<summary>Releases the underlying native instance.</summary>
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
    ///<summary>Verifies if the given object is equal to this one.</summary>
    public override bool Equals(object obj)
    {
        var other = obj as Efl.Object;
        if (other == null)
            return false;
        return this.NativeHandle == other.NativeHandle;
    }
    ///<summary>Gets the hash code for this object based on the native pointer it points to.</summary>
    public override int GetHashCode()
    {
        return this.NativeHandle.ToInt32();
    }
    ///<summary>Turns the native pointer into a string representation.</summary>
    public override String ToString()
    {
        return $"{this.GetType().Name}@[{this.NativeHandle.ToInt32():x}]";
    }
    ///<summary>Register the Eo event wrappers making the bridge to C# events. Internal usage only.</summary>
     void RegisterEventProxies()
    {
    }
    /// <summary>Interpolate the given value.</summary>
    /// <param name="progress">Input value mapped from 0.0 to 1.0.</param>
    /// <returns>Output value calculated by interpolating the input value.</returns>
    public double Interpolate( double progress) {
                                 var _ret_var = Efl.IInterpolatorNativeInherit.efl_interpolator_interpolate_ptr.Value.Delegate(this.NativeHandle, progress);
        Eina.Error.RaiseIfUnhandledException();
                        return _ret_var;
 }
    private static IntPtr GetEflClassStatic()
    {
        return Efl.IInterpolatorConcrete.efl_interpolator_interface_get();
    }
}
public class IInterpolatorNativeInherit  : Efl.Eo.NativeClass{
    public  static Efl.Eo.NativeModule _Module = new Efl.Eo.NativeModule(efl.Libs.Efl);
    public override System.Collections.Generic.List<Efl_Op_Description> GetEoOps(System.Type type)
    {
        var descs = new System.Collections.Generic.List<Efl_Op_Description>();
        var methods = Efl.Eo.Globals.GetUserMethods(type);
        if (efl_interpolator_interpolate_static_delegate == null)
            efl_interpolator_interpolate_static_delegate = new efl_interpolator_interpolate_delegate(interpolate);
        if (methods.FirstOrDefault(m => m.Name == "Interpolate") != null)
            descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_interpolator_interpolate"), func = Marshal.GetFunctionPointerForDelegate(efl_interpolator_interpolate_static_delegate)});
        return descs;
    }
    public override IntPtr GetEflClass()
    {
        return Efl.IInterpolatorConcrete.efl_interpolator_interface_get();
    }
    public static  IntPtr GetEflClassStatic()
    {
        return Efl.IInterpolatorConcrete.efl_interpolator_interface_get();
    }


     private delegate double efl_interpolator_interpolate_delegate(System.IntPtr obj, System.IntPtr pd,   double progress);


     public delegate double efl_interpolator_interpolate_api_delegate(System.IntPtr obj,   double progress);
     public static Efl.Eo.FunctionWrapper<efl_interpolator_interpolate_api_delegate> efl_interpolator_interpolate_ptr = new Efl.Eo.FunctionWrapper<efl_interpolator_interpolate_api_delegate>(_Module, "efl_interpolator_interpolate");
     private static double interpolate(System.IntPtr obj, System.IntPtr pd,  double progress)
    {
        Eina.Log.Debug("function efl_interpolator_interpolate was called");
        Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
        if(wrapper != null) {
                                                double _ret_var = default(double);
            try {
                _ret_var = ((IInterpolator)wrapper).Interpolate( progress);
            } catch (Exception e) {
                Eina.Log.Warning($"Callback error: {e.ToString()}");
                Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
            }
                        return _ret_var;
        } else {
            return efl_interpolator_interpolate_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  progress);
        }
    }
    private static efl_interpolator_interpolate_delegate efl_interpolator_interpolate_static_delegate;
}
} 
