namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (PT404InpwEeHrEfoxsFZUw)
///  <code>RC_fba30a078cd557299475777baf35d313</code> that represents <code>TI_POS_OutRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: TI_POS_OutRecord
public partial struct RC_fba30a078cd557299475777baf35d313 : ITypedRecord<RC_fba30a078cd557299475777baf35d313> {
internal static readonly GlobalObjectKey IdTI_POS_Out = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Bwqj+9WMKVeUdXd7rzXTEw");

public ST_26cbe75ae3e20157af048dd188f74dc2Structure ssSTTI_POS_Out;


public static implicit operator ST_26cbe75ae3e20157af048dd188f74dc2Structure( RC_fba30a078cd557299475777baf35d313 r) {
return r.ssSTTI_POS_Out;
}

public static implicit operator RC_fba30a078cd557299475777baf35d313 (ST_26cbe75ae3e20157af048dd188f74dc2Structure r) {
RC_fba30a078cd557299475777baf35d313 res = new RC_fba30a078cd557299475777baf35d313 ();
res.ssSTTI_POS_Out = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_fba30a078cd557299475777baf35d313() {
OptimizedAttributes = null;
ssSTTI_POS_Out = new ST_26cbe75ae3e20157af048dd188f74dc2Structure();
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
    ssSTTI_POS_Out.OptimizedAttributes = value[0];
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
ssSTTI_POS_Out.Read( r, ref index);
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
public void ReadIM(RC_fba30a078cd557299475777baf35d313 r) {
this = r;
}


public static bool operator == (RC_fba30a078cd557299475777baf35d313 a, RC_fba30a078cd557299475777baf35d313 b) {
if (a.ssSTTI_POS_Out != b.ssSTTI_POS_Out) return false;
return true;
}

public static bool operator != (RC_fba30a078cd557299475777baf35d313 a, RC_fba30a078cd557299475777baf35d313 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_fba30a078cd557299475777baf35d313)) return false;
return (this == (RC_fba30a078cd557299475777baf35d313)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTTI_POS_Out.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTTI_POS_Out.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTTI_POS_Out.InternalRecursiveSave();
}


public RC_fba30a078cd557299475777baf35d313 Duplicate() {
RC_fba30a078cd557299475777baf35d313 t;
t.ssSTTI_POS_Out = (ST_26cbe75ae3e20157af048dd188f74dc2Structure)this.ssSTTI_POS_Out.Duplicate();
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
if (head == "ti_pos_out") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TI_POS_Out")) variable.Value = ssSTTI_POS_Out; else variable.Optimized = true;
variable.SetFieldName("ti_pos_out");
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
if (key == IdTI_POS_Out) {
return ssSTTI_POS_Out;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdTI_POS_Out.Key.AsGuid) {
return ssSTTI_POS_Out;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTTI_POS_Out.FillFromOther((IRecord) other.AttributeGet(IdTI_POS_Out));
}
} // RC_fba30a078cd557299475777baf35d313
/// <summary>
/// RecordList type <code>TI_POS_OutRecordList</code> that represents a record list of
///  <code>TI_POS_Out</code>
/// </summary>
public partial class RL_be6b44f246bff4173f7ce2a966c1cef1 : GenericRecordList<RC_fba30a078cd557299475777baf35d313>, IEnumerable, IEnumerator {

protected override RC_fba30a078cd557299475777baf35d313 GetElementDefaultValue() {
return new RC_fba30a078cd557299475777baf35d313();
}

public T[] ToArray<T>(Func<RC_fba30a078cd557299475777baf35d313, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_be6b44f246bff4173f7ce2a966c1cef1 recordList, Func<RC_fba30a078cd557299475777baf35d313, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_be6b44f246bff4173f7ce2a966c1cef1(RC_fba30a078cd557299475777baf35d313[] array) {
  RL_be6b44f246bff4173f7ce2a966c1cef1 result = new RL_be6b44f246bff4173f7ce2a966c1cef1();
result.InnerFromArray(array);
    return result;
}

public static RL_be6b44f246bff4173f7ce2a966c1cef1 ToList<T>(T[] array, Func <T, RC_fba30a078cd557299475777baf35d313> converter) {
  RL_be6b44f246bff4173f7ce2a966c1cef1 result = new RL_be6b44f246bff4173f7ce2a966c1cef1();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_be6b44f246bff4173f7ce2a966c1cef1 FromRestList<T>(RestList<T> restList, Func <T, RC_fba30a078cd557299475777baf35d313> converter) {
  RL_be6b44f246bff4173f7ce2a966c1cef1 result = new RL_be6b44f246bff4173f7ce2a966c1cef1();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_be6b44f246bff4173f7ce2a966c1cef1() : base() {
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
protected override OSList<RC_fba30a078cd557299475777baf35d313> NewList() {
return new RL_be6b44f246bff4173f7ce2a966c1cef1();
}


} // RL_be6b44f246bff4173f7ce2a966c1cef1
}

