namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] T_FAC_PAG_CAB_In (3MOc4XAHsE6zsaVLV9VXsw)
///  <code>ST_828ac715d3b2e46c74367f017543eab1Structure</code> that represent
/// s <code>T_FAC_PAG_CAB_In</code> <p>Description: </p>
/// </summary>
// Name: T_FAC_PAG_CAB_In
public partial struct ST_828ac715d3b2e46c74367f017543eab1Structure : ITypedRecord<ST_828ac715d3b2e46c74367f017543eab1Structure> {
internal static readonly GlobalObjectKey IdKURSF = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*qkdU69otdk6ISeGjOsvPoA");
internal static readonly GlobalObjectKey IdAUGBL = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*hIU_I9s+P0KVlIBV3in4VA");

public decimal ssKURSF;

public string ssAUGBL;


public BitArray OptimizedAttributes;

public ST_828ac715d3b2e46c74367f017543eab1Structure() {
OptimizedAttributes = null;
ssKURSF = -79228162514264337593543950335m;
ssAUGBL = "";
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssKURSF = r.ReadDecimal(index++, "T_FAC_PAG_CAB_In.KURSF", 0.0M);
ssAUGBL = r.ReadText(index++, "T_FAC_PAG_CAB_In.AUGBL", "");
}
/// <summary>
/// Read from database
/// </summary>
/// <param name="r"> Data reader</param>
public void ReadDB( DbDataReader r) {
int index = 0;
Read(r, ref index);
}

/// <summary>
/// Read from record
/// </summary>
/// <param name="r"> Record</param>
public void ReadIM(ST_828ac715d3b2e46c74367f017543eab1Structure r) {
this = r;
}


public static bool operator == (ST_828ac715d3b2e46c74367f017543eab1Structure a, ST_828ac715d3b2e46c74367f017543eab1Structure b) {
if (a.ssKURSF != b.ssKURSF) return false;
if (a.ssAUGBL != b.ssAUGBL) return false;
return true;
}

public static bool operator != (ST_828ac715d3b2e46c74367f017543eab1Structure a, ST_828ac715d3b2e46c74367f017543eab1Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_828ac715d3b2e46c74367f017543eab1Structure)) return false;
return (this == (ST_828ac715d3b2e46c74367f017543eab1Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssKURSF.GetHashCode()
 ^ ssAUGBL.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_828ac715d3b2e46c74367f017543eab1Structure Duplicate() {
ST_828ac715d3b2e46c74367f017543eab1Structure t;
t.ssKURSF = this.ssKURSF;
t.ssAUGBL = this.ssAUGBL;
t.OptimizedAttributes = null;
return t;
}

IRecord IRecord.Duplicate() {
return Duplicate();
}

public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
throw new System.InvalidOperationException();
}

public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
String head = VarValue.GetHead(fields);
String tail = VarValue.GetTail(fields);
variable.Found = false;
if (head == "kursf") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".KURSF")) variable.Value = ssKURSF; else variable.Optimized = true;
} else if (head == "augbl") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AUGBL")) variable.Value = ssAUGBL; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdKURSF) {
return ssKURSF;
}
if (key == IdAUGBL) {
return ssAUGBL;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdKURSF.Key.AsGuid) {
return ssKURSF;
}
if (attributeKey == IdAUGBL.Key.AsGuid) {
return ssAUGBL;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssKURSF = (decimal) other.AttributeGet(IdKURSF);
ssAUGBL = (string) other.AttributeGet(IdAUGBL);
}
} // ST_828ac715d3b2e46c74367f017543eab1Structure
/// <summary>
/// RecordList type <code>T_FAC_PAG_CAB_InList</code> that represents a record list of
///  <code>T_FAC_PAG_CAB_In</code>
/// </summary>
public partial class RL_26adac9723b2e9519247bc502c06c341 : GenericRecordList<ST_828ac715d3b2e46c74367f017543eab1Structure>, IEnumerable, IEnumerator {

protected override ST_828ac715d3b2e46c74367f017543eab1Structure GetElementDefaultValue() {
return new ST_828ac715d3b2e46c74367f017543eab1Structure();
}

public T[] ToArray<T>(Func<ST_828ac715d3b2e46c74367f017543eab1Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_26adac9723b2e9519247bc502c06c341 recordList, Func<ST_828ac715d3b2e46c74367f017543eab1Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_26adac9723b2e9519247bc502c06c341(ST_828ac715d3b2e46c74367f017543eab1Structure[] array) {
  RL_26adac9723b2e9519247bc502c06c341 result = new RL_26adac9723b2e9519247bc502c06c341();
result.InnerFromArray(array);
    return result;
}

public static RL_26adac9723b2e9519247bc502c06c341 ToList<T>(T[] array, Func <T, ST_828ac715d3b2e46c74367f017543eab1Structure> converter) {
  RL_26adac9723b2e9519247bc502c06c341 result = new RL_26adac9723b2e9519247bc502c06c341();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_26adac9723b2e9519247bc502c06c341 FromRestList<T>(RestList<T> restList, Func <T, ST_828ac715d3b2e46c74367f017543eab1Structure> converter) {
  RL_26adac9723b2e9519247bc502c06c341 result = new RL_26adac9723b2e9519247bc502c06c341();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_26adac9723b2e9519247bc502c06c341() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_828ac715d3b2e46c74367f017543eab1Structure> NewList() {
return new RL_26adac9723b2e9519247bc502c06c341();
}


} // RL_26adac9723b2e9519247bc502c06c341
}

