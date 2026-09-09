namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (qwqqc3D1pkKEb4LALjxYmQ)
///  <code>RC_08daffa670c72e7502779e59a7b292d3</code> that represent
/// s <code>RequisitionCommentRecord</code> <p>Description: </p>
/// </summary>
// Name: RequisitionCommentRecord
public partial struct RC_08daffa670c72e7502779e59a7b292d3 : ITypedRecord<RC_08daffa670c72e7502779e59a7b292d3> {
internal static readonly GlobalObjectKey IdRequisitionComment = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*pv_aCMdwdS4Cd55Zp7KS0w");

public EN_cbeb601b681344342c8de0161d058f87EntityRecord ssENRequisitionComment;


public static implicit operator EN_cbeb601b681344342c8de0161d058f87EntityRecord( RC_08daffa670c72e7502779e59a7b292d3 r) {
return r.ssENRequisitionComment;
}

public static implicit operator RC_08daffa670c72e7502779e59a7b292d3 (EN_cbeb601b681344342c8de0161d058f87EntityRecord r) {
RC_08daffa670c72e7502779e59a7b292d3 res = new RC_08daffa670c72e7502779e59a7b292d3 ();
res.ssENRequisitionComment = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENRequisitionComment.ChangedAttributes = value;
}
get {
    return ssENRequisitionComment.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_08daffa670c72e7502779e59a7b292d3() {
OptimizedAttributes = null;
ssENRequisitionComment = new EN_cbeb601b681344342c8de0161d058f87EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(8,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENRequisitionComment.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENRequisitionComment.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENRequisitionComment.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENRequisitionComment.Read( r, ref index);
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
public void ReadIM(RC_08daffa670c72e7502779e59a7b292d3 r) {
this = r;
}


public static bool operator == (RC_08daffa670c72e7502779e59a7b292d3 a, RC_08daffa670c72e7502779e59a7b292d3 b) {
if (a.ssENRequisitionComment != b.ssENRequisitionComment) return false;
return true;
}

public static bool operator != (RC_08daffa670c72e7502779e59a7b292d3 a, RC_08daffa670c72e7502779e59a7b292d3 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_08daffa670c72e7502779e59a7b292d3)) return false;
return (this == (RC_08daffa670c72e7502779e59a7b292d3)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENRequisitionComment.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENRequisitionComment.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENRequisitionComment.InternalRecursiveSave();
}


public RC_08daffa670c72e7502779e59a7b292d3 Duplicate() {
RC_08daffa670c72e7502779e59a7b292d3 t;
t.ssENRequisitionComment = (EN_cbeb601b681344342c8de0161d058f87EntityRecord)this.ssENRequisitionComment.Duplicate();
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
if (head == "requisitioncomment") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionComment")) variable.Value = ssENRequisitionComment; else variable.Optimized = true;
variable.SetFieldName("requisitioncomment");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENRequisitionComment.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENRequisitionComment.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdRequisitionComment) {
return ssENRequisitionComment;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRequisitionComment.Key.AsGuid) {
return ssENRequisitionComment;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENRequisitionComment.FillFromOther((IRecord) other.AttributeGet(IdRequisitionComment));
}
} // RC_08daffa670c72e7502779e59a7b292d3
/// <summary>
/// RecordList type <code>RequisitionCommentRecordList</code> that represents a record list of
///  <code>RequisitionComment</code>
/// </summary>
public partial class RL_3933323760320045e42588bf0a23c855 : GenericRecordList<RC_08daffa670c72e7502779e59a7b292d3>, IEnumerable, IEnumerator {

protected override RC_08daffa670c72e7502779e59a7b292d3 GetElementDefaultValue() {
return new RC_08daffa670c72e7502779e59a7b292d3();
}

public T[] ToArray<T>(Func<RC_08daffa670c72e7502779e59a7b292d3, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_3933323760320045e42588bf0a23c855 recordList, Func<RC_08daffa670c72e7502779e59a7b292d3, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_3933323760320045e42588bf0a23c855(RC_08daffa670c72e7502779e59a7b292d3[] array) {
  RL_3933323760320045e42588bf0a23c855 result = new RL_3933323760320045e42588bf0a23c855();
result.InnerFromArray(array);
    return result;
}

public static RL_3933323760320045e42588bf0a23c855 ToList<T>(T[] array, Func <T, RC_08daffa670c72e7502779e59a7b292d3> converter) {
  RL_3933323760320045e42588bf0a23c855 result = new RL_3933323760320045e42588bf0a23c855();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_3933323760320045e42588bf0a23c855 FromRestList<T>(RestList<T> restList, Func <T, RC_08daffa670c72e7502779e59a7b292d3> converter) {
  RL_3933323760320045e42588bf0a23c855 result = new RL_3933323760320045e42588bf0a23c855();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_3933323760320045e42588bf0a23c855() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(8,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_08daffa670c72e7502779e59a7b292d3> NewList() {
return new RL_3933323760320045e42588bf0a23c855();
}


} // RL_3933323760320045e42588bf0a23c855
}

