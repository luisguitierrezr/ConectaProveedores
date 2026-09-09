namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] T_FAC_PAG_CAB_Out (yHpxrqNXgE+XuG8sL3OS0w)
///  <code>ST_27647b039a03d40c5b921de2dccb61f4Structure</code> that represent
/// s <code>T_FAC_PAG_CAB_Out</code> <p>Description: </p>
/// </summary>
// Name: T_FAC_PAG_CAB_Out
public partial struct ST_27647b039a03d40c5b921de2dccb61f4Structure : ITypedRecord<ST_27647b039a03d40c5b921de2dccb61f4Structure> {
internal static readonly GlobalObjectKey IdKURSF = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*9GcEvR52cUGu3WOdsuMFpg");
internal static readonly GlobalObjectKey IdAUGBL = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*t9KKIDf63ESI199t0TTphg");

public decimal ssKURSF;

public string ssAUGBL;


public BitArray OptimizedAttributes;

public ST_27647b039a03d40c5b921de2dccb61f4Structure() {
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
ssKURSF = r.ReadDecimal(index++, "T_FAC_PAG_CAB_Out.KURSF", 0.0M);
ssAUGBL = r.ReadText(index++, "T_FAC_PAG_CAB_Out.AUGBL", "");
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
public void ReadIM(ST_27647b039a03d40c5b921de2dccb61f4Structure r) {
this = r;
}


public static bool operator == (ST_27647b039a03d40c5b921de2dccb61f4Structure a, ST_27647b039a03d40c5b921de2dccb61f4Structure b) {
if (a.ssKURSF != b.ssKURSF) return false;
if (a.ssAUGBL != b.ssAUGBL) return false;
return true;
}

public static bool operator != (ST_27647b039a03d40c5b921de2dccb61f4Structure a, ST_27647b039a03d40c5b921de2dccb61f4Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_27647b039a03d40c5b921de2dccb61f4Structure)) return false;
return (this == (ST_27647b039a03d40c5b921de2dccb61f4Structure)o);
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


public ST_27647b039a03d40c5b921de2dccb61f4Structure Duplicate() {
ST_27647b039a03d40c5b921de2dccb61f4Structure t;
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
} // ST_27647b039a03d40c5b921de2dccb61f4Structure
/// <summary>
/// RecordList type <code>T_FAC_PAG_CAB_OutList</code> that represents a record list of
///  <code>T_FAC_PAG_CAB_Out</code>
/// </summary>
public partial class RL_c269559318987f7f9b248e427dd83abb : GenericRecordList<ST_27647b039a03d40c5b921de2dccb61f4Structure>, IEnumerable, IEnumerator {

protected override ST_27647b039a03d40c5b921de2dccb61f4Structure GetElementDefaultValue() {
return new ST_27647b039a03d40c5b921de2dccb61f4Structure();
}

public T[] ToArray<T>(Func<ST_27647b039a03d40c5b921de2dccb61f4Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c269559318987f7f9b248e427dd83abb recordList, Func<ST_27647b039a03d40c5b921de2dccb61f4Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c269559318987f7f9b248e427dd83abb(ST_27647b039a03d40c5b921de2dccb61f4Structure[] array) {
  RL_c269559318987f7f9b248e427dd83abb result = new RL_c269559318987f7f9b248e427dd83abb();
result.InnerFromArray(array);
    return result;
}

public static RL_c269559318987f7f9b248e427dd83abb ToList<T>(T[] array, Func <T, ST_27647b039a03d40c5b921de2dccb61f4Structure> converter) {
  RL_c269559318987f7f9b248e427dd83abb result = new RL_c269559318987f7f9b248e427dd83abb();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c269559318987f7f9b248e427dd83abb FromRestList<T>(RestList<T> restList, Func <T, ST_27647b039a03d40c5b921de2dccb61f4Structure> converter) {
  RL_c269559318987f7f9b248e427dd83abb result = new RL_c269559318987f7f9b248e427dd83abb();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c269559318987f7f9b248e427dd83abb() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_27647b039a03d40c5b921de2dccb61f4Structure> NewList() {
return new RL_c269559318987f7f9b248e427dd83abb();
}


} // RL_c269559318987f7f9b248e427dd83abb
}

