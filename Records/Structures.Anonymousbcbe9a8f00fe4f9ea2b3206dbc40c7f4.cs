namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (j5q+vP4Ank+isyBtvEDH9A)
///  <code>RC_b87fa9e4edd3dd8574880501160c11fc</code> that represents <code>MFU_ErrorRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: MFU_ErrorRecord
public partial struct RC_b87fa9e4edd3dd8574880501160c11fc : ITypedRecord<RC_b87fa9e4edd3dd8574880501160c11fc> {
internal static readonly GlobalObjectKey IdMFU_Error = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*5Kl_uNPthd10iAUBFgwR_A");

public ST_f9f8b40f5330871047e55e068d129447Structure ssSTMFU_Error;


public static implicit operator ST_f9f8b40f5330871047e55e068d129447Structure( RC_b87fa9e4edd3dd8574880501160c11fc r) {
return r.ssSTMFU_Error;
}

public static implicit operator RC_b87fa9e4edd3dd8574880501160c11fc (ST_f9f8b40f5330871047e55e068d129447Structure r) {
RC_b87fa9e4edd3dd8574880501160c11fc res = new RC_b87fa9e4edd3dd8574880501160c11fc ();
res.ssSTMFU_Error = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_b87fa9e4edd3dd8574880501160c11fc() {
OptimizedAttributes = null;
ssSTMFU_Error = new ST_f9f8b40f5330871047e55e068d129447Structure();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssSTMFU_Error.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssSTMFU_Error.Read( r, ref index);
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
public void ReadIM(RC_b87fa9e4edd3dd8574880501160c11fc r) {
this = r;
}


public static bool operator == (RC_b87fa9e4edd3dd8574880501160c11fc a, RC_b87fa9e4edd3dd8574880501160c11fc b) {
if (a.ssSTMFU_Error != b.ssSTMFU_Error) return false;
return true;
}

public static bool operator != (RC_b87fa9e4edd3dd8574880501160c11fc a, RC_b87fa9e4edd3dd8574880501160c11fc b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_b87fa9e4edd3dd8574880501160c11fc)) return false;
return (this == (RC_b87fa9e4edd3dd8574880501160c11fc)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTMFU_Error.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTMFU_Error.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTMFU_Error.InternalRecursiveSave();
}


public RC_b87fa9e4edd3dd8574880501160c11fc Duplicate() {
RC_b87fa9e4edd3dd8574880501160c11fc t;
t.ssSTMFU_Error = (ST_f9f8b40f5330871047e55e068d129447Structure)this.ssSTMFU_Error.Duplicate();
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
if (head == "mfu_error") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MFU_Error")) variable.Value = ssSTMFU_Error; else variable.Optimized = true;
variable.SetFieldName("mfu_error");
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
if (key == IdMFU_Error) {
return ssSTMFU_Error;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdMFU_Error.Key.AsGuid) {
return ssSTMFU_Error;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTMFU_Error.FillFromOther((IRecord) other.AttributeGet(IdMFU_Error));
}
} // RC_b87fa9e4edd3dd8574880501160c11fc
/// <summary>
/// RecordList type <code>MFU_ErrorRecordList</code> that represents a record list of
///  <code>MFU_Error</code>
/// </summary>
public partial class RL_dafad05405ffc87f1c03fff40d4e35fe : GenericRecordList<RC_b87fa9e4edd3dd8574880501160c11fc>, IEnumerable, IEnumerator {

protected override RC_b87fa9e4edd3dd8574880501160c11fc GetElementDefaultValue() {
return new RC_b87fa9e4edd3dd8574880501160c11fc();
}

public T[] ToArray<T>(Func<RC_b87fa9e4edd3dd8574880501160c11fc, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_dafad05405ffc87f1c03fff40d4e35fe recordList, Func<RC_b87fa9e4edd3dd8574880501160c11fc, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_dafad05405ffc87f1c03fff40d4e35fe(RC_b87fa9e4edd3dd8574880501160c11fc[] array) {
  RL_dafad05405ffc87f1c03fff40d4e35fe result = new RL_dafad05405ffc87f1c03fff40d4e35fe();
result.InnerFromArray(array);
    return result;
}

public static RL_dafad05405ffc87f1c03fff40d4e35fe ToList<T>(T[] array, Func <T, RC_b87fa9e4edd3dd8574880501160c11fc> converter) {
  RL_dafad05405ffc87f1c03fff40d4e35fe result = new RL_dafad05405ffc87f1c03fff40d4e35fe();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_dafad05405ffc87f1c03fff40d4e35fe FromRestList<T>(RestList<T> restList, Func <T, RC_b87fa9e4edd3dd8574880501160c11fc> converter) {
  RL_dafad05405ffc87f1c03fff40d4e35fe result = new RL_dafad05405ffc87f1c03fff40d4e35fe();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_dafad05405ffc87f1c03fff40d4e35fe() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_b87fa9e4edd3dd8574880501160c11fc> NewList() {
return new RL_dafad05405ffc87f1c03fff40d4e35fe();
}


} // RL_dafad05405ffc87f1c03fff40d4e35fe
}

