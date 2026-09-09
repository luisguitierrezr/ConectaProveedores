namespace ssConectaProveedores {
/// <summary>
/// [Structure] InvoicesReport48_5Files (l8HS2UlPSU+Vr07Ca6LoKQ)
///  <code>ST_67affae36317a1bf9109868208ade0a8Structure</code> that represent
/// s <code>InvoicesReport48_5Files</code> <p>Description: </p>
/// </summary>
// Name: InvoicesReport48_5Files
public partial struct ST_67affae36317a1bf9109868208ade0a8Structure : ITypedRecord<ST_67affae36317a1bf9109868208ade0a8Structure> {
internal static readonly GlobalObjectKey IdPdfName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*RJboR1TUZkKW0gO3IhAeDQ");
internal static readonly GlobalObjectKey IdXmlName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*pPTbOdmrPEWoBSqd+3ickA");
internal static readonly GlobalObjectKey IdUUID = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*XhSNitQiQESyGjoJkZKRIw");
internal static readonly GlobalObjectKey IdCostCenters = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*qUbV0JDT50C6VCOyL2AAiQ");

public string ssPdfName;

public string ssXmlName;

public string ssUUID;

public string ssCostCenters;


public BitArray OptimizedAttributes;

public ST_67affae36317a1bf9109868208ade0a8Structure() {
OptimizedAttributes = null;
ssPdfName = "";
ssXmlName = "";
ssUUID = "";
ssCostCenters = "";
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
ssPdfName = r.ReadText(index++, "InvoicesReport48_5Files.PdfName", "");
ssXmlName = r.ReadText(index++, "InvoicesReport48_5Files.XmlName", "");
ssUUID = r.ReadText(index++, "InvoicesReport48_5Files.UUID", "");
ssCostCenters = r.ReadText(index++, "InvoicesReport48_5Files.CostCenters", "");
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
public void ReadIM(ST_67affae36317a1bf9109868208ade0a8Structure r) {
this = r;
}


public static bool operator == (ST_67affae36317a1bf9109868208ade0a8Structure a, ST_67affae36317a1bf9109868208ade0a8Structure b) {
if (a.ssPdfName != b.ssPdfName) return false;
if (a.ssXmlName != b.ssXmlName) return false;
if (a.ssUUID != b.ssUUID) return false;
if (a.ssCostCenters != b.ssCostCenters) return false;
return true;
}

public static bool operator != (ST_67affae36317a1bf9109868208ade0a8Structure a, ST_67affae36317a1bf9109868208ade0a8Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_67affae36317a1bf9109868208ade0a8Structure)) return false;
return (this == (ST_67affae36317a1bf9109868208ade0a8Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssPdfName.GetHashCode()
 ^ ssXmlName.GetHashCode()
 ^ ssUUID.GetHashCode()
 ^ ssCostCenters.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_67affae36317a1bf9109868208ade0a8Structure Duplicate() {
ST_67affae36317a1bf9109868208ade0a8Structure t;
t.ssPdfName = this.ssPdfName;
t.ssXmlName = this.ssXmlName;
t.ssUUID = this.ssUUID;
t.ssCostCenters = this.ssCostCenters;
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
if (head == "pdfname") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PdfName")) variable.Value = ssPdfName; else variable.Optimized = true;
} else if (head == "xmlname") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".XmlName")) variable.Value = ssXmlName; else variable.Optimized = true;
} else if (head == "uuid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UUID")) variable.Value = ssUUID; else variable.Optimized = true;
} else if (head == "costcenters") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CostCenters")) variable.Value = ssCostCenters; else variable.Optimized = true;
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
if (key == IdPdfName) {
return ssPdfName;
}
if (key == IdXmlName) {
return ssXmlName;
}
if (key == IdUUID) {
return ssUUID;
}
if (key == IdCostCenters) {
return ssCostCenters;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPdfName.Key.AsGuid) {
return ssPdfName;
}
if (attributeKey == IdXmlName.Key.AsGuid) {
return ssXmlName;
}
if (attributeKey == IdUUID.Key.AsGuid) {
return ssUUID;
}
if (attributeKey == IdCostCenters.Key.AsGuid) {
return ssCostCenters;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssPdfName = (string) other.AttributeGet(IdPdfName);
ssXmlName = (string) other.AttributeGet(IdXmlName);
ssUUID = (string) other.AttributeGet(IdUUID);
ssCostCenters = (string) other.AttributeGet(IdCostCenters);
}
} // ST_67affae36317a1bf9109868208ade0a8Structure
/// <summary>
/// RecordList type <code>InvoicesReport48_5FilesList</code> that represents a record list of
///  <code>InvoicesReport48_5Files</code>
/// </summary>
public partial class RL_6fb0c4970824a19a24043a34c78c421d : GenericRecordList<ST_67affae36317a1bf9109868208ade0a8Structure>, IEnumerable, IEnumerator {

protected override ST_67affae36317a1bf9109868208ade0a8Structure GetElementDefaultValue() {
return new ST_67affae36317a1bf9109868208ade0a8Structure();
}

public T[] ToArray<T>(Func<ST_67affae36317a1bf9109868208ade0a8Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_6fb0c4970824a19a24043a34c78c421d recordList, Func<ST_67affae36317a1bf9109868208ade0a8Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_6fb0c4970824a19a24043a34c78c421d(ST_67affae36317a1bf9109868208ade0a8Structure[] array) {
  RL_6fb0c4970824a19a24043a34c78c421d result = new RL_6fb0c4970824a19a24043a34c78c421d();
result.InnerFromArray(array);
    return result;
}

public static RL_6fb0c4970824a19a24043a34c78c421d ToList<T>(T[] array, Func <T, ST_67affae36317a1bf9109868208ade0a8Structure> converter) {
  RL_6fb0c4970824a19a24043a34c78c421d result = new RL_6fb0c4970824a19a24043a34c78c421d();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_6fb0c4970824a19a24043a34c78c421d FromRestList<T>(RestList<T> restList, Func <T, ST_67affae36317a1bf9109868208ade0a8Structure> converter) {
  RL_6fb0c4970824a19a24043a34c78c421d result = new RL_6fb0c4970824a19a24043a34c78c421d();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_6fb0c4970824a19a24043a34c78c421d() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_67affae36317a1bf9109868208ade0a8Structure> NewList() {
return new RL_6fb0c4970824a19a24043a34c78c421d();
}


} // RL_6fb0c4970824a19a24043a34c78c421d
}

