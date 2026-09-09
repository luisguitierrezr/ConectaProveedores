namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (cpr0qZK1wUqd1YJyxhIm8Q)
///  <code>RC_c4f3f57be4398f0d8a99656890ed9dae</code> that represent
/// s <code>RequisitionList_StructMobileRecord</code> <p>Description: </p>
/// </summary>
// Name: RequisitionList_StructMobileRecord
public partial struct RC_c4f3f57be4398f0d8a99656890ed9dae : ITypedRecord<RC_c4f3f57be4398f0d8a99656890ed9dae> {
internal static readonly GlobalObjectKey IdRequisitionList_StructMobile = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*e_XzxDnkDY+KmWVokO2drg");

public ST_93db82ada2d57fd9d5e68feb0d1d4360Structure ssSTRequisitionList_StructMobile;


public static implicit operator ST_93db82ada2d57fd9d5e68feb0d1d4360Structure( RC_c4f3f57be4398f0d8a99656890ed9dae r) {
return r.ssSTRequisitionList_StructMobile;
}

public static implicit operator RC_c4f3f57be4398f0d8a99656890ed9dae (ST_93db82ada2d57fd9d5e68feb0d1d4360Structure r) {
RC_c4f3f57be4398f0d8a99656890ed9dae res = new RC_c4f3f57be4398f0d8a99656890ed9dae ();
res.ssSTRequisitionList_StructMobile = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_c4f3f57be4398f0d8a99656890ed9dae() {
OptimizedAttributes = null;
ssSTRequisitionList_StructMobile = new ST_93db82ada2d57fd9d5e68feb0d1d4360Structure();
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
    ssSTRequisitionList_StructMobile.OptimizedAttributes = value[0];
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
ssSTRequisitionList_StructMobile.Read( r, ref index);
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
public void ReadIM(RC_c4f3f57be4398f0d8a99656890ed9dae r) {
this = r;
}


public static bool operator == (RC_c4f3f57be4398f0d8a99656890ed9dae a, RC_c4f3f57be4398f0d8a99656890ed9dae b) {
if (a.ssSTRequisitionList_StructMobile != b.ssSTRequisitionList_StructMobile) return false;
return true;
}

public static bool operator != (RC_c4f3f57be4398f0d8a99656890ed9dae a, RC_c4f3f57be4398f0d8a99656890ed9dae b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_c4f3f57be4398f0d8a99656890ed9dae)) return false;
return (this == (RC_c4f3f57be4398f0d8a99656890ed9dae)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTRequisitionList_StructMobile.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTRequisitionList_StructMobile.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTRequisitionList_StructMobile.InternalRecursiveSave();
}


public RC_c4f3f57be4398f0d8a99656890ed9dae Duplicate() {
RC_c4f3f57be4398f0d8a99656890ed9dae t;
t.ssSTRequisitionList_StructMobile = (ST_93db82ada2d57fd9d5e68feb0d1d4360Structure)this.ssSTRequisitionList_StructMobile.Duplicate();
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
if (head == "requisitionlist_structmobile") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionList_StructMobile")) variable.Value = ssSTRequisitionList_StructMobile; else variable.Optimized = true;
variable.SetFieldName("requisitionlist_structmobile");
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
if (key == IdRequisitionList_StructMobile) {
return ssSTRequisitionList_StructMobile;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRequisitionList_StructMobile.Key.AsGuid) {
return ssSTRequisitionList_StructMobile;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTRequisitionList_StructMobile.FillFromOther((IRecord) other.AttributeGet(IdRequisitionList_StructMobile));
}
} // RC_c4f3f57be4398f0d8a99656890ed9dae
/// <summary>
/// RecordList type <code>RequisitionList_StructMobileRecordList</code> that represents a record list
///  of <code>RequisitionList_StructMobile</code>
/// </summary>
public partial class RL_8365613fe8b9250421c71137e60527cb : GenericRecordList<RC_c4f3f57be4398f0d8a99656890ed9dae>, IEnumerable, IEnumerator {

protected override RC_c4f3f57be4398f0d8a99656890ed9dae GetElementDefaultValue() {
return new RC_c4f3f57be4398f0d8a99656890ed9dae();
}

public T[] ToArray<T>(Func<RC_c4f3f57be4398f0d8a99656890ed9dae, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_8365613fe8b9250421c71137e60527cb recordList, Func<RC_c4f3f57be4398f0d8a99656890ed9dae, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_8365613fe8b9250421c71137e60527cb(RC_c4f3f57be4398f0d8a99656890ed9dae[] array) {
  RL_8365613fe8b9250421c71137e60527cb result = new RL_8365613fe8b9250421c71137e60527cb();
result.InnerFromArray(array);
    return result;
}

public static RL_8365613fe8b9250421c71137e60527cb ToList<T>(T[] array, Func <T, RC_c4f3f57be4398f0d8a99656890ed9dae> converter) {
  RL_8365613fe8b9250421c71137e60527cb result = new RL_8365613fe8b9250421c71137e60527cb();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_8365613fe8b9250421c71137e60527cb FromRestList<T>(RestList<T> restList, Func <T, RC_c4f3f57be4398f0d8a99656890ed9dae> converter) {
  RL_8365613fe8b9250421c71137e60527cb result = new RL_8365613fe8b9250421c71137e60527cb();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_8365613fe8b9250421c71137e60527cb() : base() {
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
protected override OSList<RC_c4f3f57be4398f0d8a99656890ed9dae> NewList() {
return new RL_8365613fe8b9250421c71137e60527cb();
}


} // RL_8365613fe8b9250421c71137e60527cb
}

