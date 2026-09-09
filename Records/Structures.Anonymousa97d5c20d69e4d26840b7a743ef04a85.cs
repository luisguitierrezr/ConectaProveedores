namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (IFx9qZ7WJk2EC3p0PvBKhQ)
///  <code>RC_8f1c2b4902cba2d0c0cbb5fb1e978b50</code> that represents <code>FolioApprovalRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: FolioApprovalRecord
public partial struct RC_8f1c2b4902cba2d0c0cbb5fb1e978b50 : ITypedRecord<RC_8f1c2b4902cba2d0c0cbb5fb1e978b50> {
internal static readonly GlobalObjectKey IdFolioApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SSscj8sC0KLAy7X7HpeLUA");

public EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord ssENFolioApproval;


public static implicit operator EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord( RC_8f1c2b4902cba2d0c0cbb5fb1e978b50 r) {
return r.ssENFolioApproval;
}

public static implicit operator RC_8f1c2b4902cba2d0c0cbb5fb1e978b50 (EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord r) {
RC_8f1c2b4902cba2d0c0cbb5fb1e978b50 res = new RC_8f1c2b4902cba2d0c0cbb5fb1e978b50 ();
res.ssENFolioApproval = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENFolioApproval.ChangedAttributes = value;
}
get {
    return ssENFolioApproval.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_8f1c2b4902cba2d0c0cbb5fb1e978b50() {
OptimizedAttributes = null;
ssENFolioApproval = new EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(10,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENFolioApproval.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENFolioApproval.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENFolioApproval.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENFolioApproval.Read( r, ref index);
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
public void ReadIM(RC_8f1c2b4902cba2d0c0cbb5fb1e978b50 r) {
this = r;
}


public static bool operator == (RC_8f1c2b4902cba2d0c0cbb5fb1e978b50 a, RC_8f1c2b4902cba2d0c0cbb5fb1e978b50 b) {
if (a.ssENFolioApproval != b.ssENFolioApproval) return false;
return true;
}

public static bool operator != (RC_8f1c2b4902cba2d0c0cbb5fb1e978b50 a, RC_8f1c2b4902cba2d0c0cbb5fb1e978b50 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_8f1c2b4902cba2d0c0cbb5fb1e978b50)) return false;
return (this == (RC_8f1c2b4902cba2d0c0cbb5fb1e978b50)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENFolioApproval.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENFolioApproval.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENFolioApproval.InternalRecursiveSave();
}


public RC_8f1c2b4902cba2d0c0cbb5fb1e978b50 Duplicate() {
RC_8f1c2b4902cba2d0c0cbb5fb1e978b50 t;
t.ssENFolioApproval = (EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord)this.ssENFolioApproval.Duplicate();
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
if (head == "folioapproval") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioApproval")) variable.Value = ssENFolioApproval; else variable.Optimized = true;
variable.SetFieldName("folioapproval");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENFolioApproval.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENFolioApproval.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdFolioApproval) {
return ssENFolioApproval;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFolioApproval.Key.AsGuid) {
return ssENFolioApproval;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENFolioApproval.FillFromOther((IRecord) other.AttributeGet(IdFolioApproval));
}
} // RC_8f1c2b4902cba2d0c0cbb5fb1e978b50
/// <summary>
/// RecordList type <code>FolioApprovalRecordList</code> that represents a record list of
///  <code>FolioApproval</code>
/// </summary>
public partial class RL_b442351480b89deb6222b9dd043cac65 : GenericRecordList<RC_8f1c2b4902cba2d0c0cbb5fb1e978b50>, IEnumerable, IEnumerator {

protected override RC_8f1c2b4902cba2d0c0cbb5fb1e978b50 GetElementDefaultValue() {
return new RC_8f1c2b4902cba2d0c0cbb5fb1e978b50();
}

public T[] ToArray<T>(Func<RC_8f1c2b4902cba2d0c0cbb5fb1e978b50, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_b442351480b89deb6222b9dd043cac65 recordList, Func<RC_8f1c2b4902cba2d0c0cbb5fb1e978b50, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_b442351480b89deb6222b9dd043cac65(RC_8f1c2b4902cba2d0c0cbb5fb1e978b50[] array) {
  RL_b442351480b89deb6222b9dd043cac65 result = new RL_b442351480b89deb6222b9dd043cac65();
result.InnerFromArray(array);
    return result;
}

public static RL_b442351480b89deb6222b9dd043cac65 ToList<T>(T[] array, Func <T, RC_8f1c2b4902cba2d0c0cbb5fb1e978b50> converter) {
  RL_b442351480b89deb6222b9dd043cac65 result = new RL_b442351480b89deb6222b9dd043cac65();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_b442351480b89deb6222b9dd043cac65 FromRestList<T>(RestList<T> restList, Func <T, RC_8f1c2b4902cba2d0c0cbb5fb1e978b50> converter) {
  RL_b442351480b89deb6222b9dd043cac65 result = new RL_b442351480b89deb6222b9dd043cac65();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_b442351480b89deb6222b9dd043cac65() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(10,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_8f1c2b4902cba2d0c0cbb5fb1e978b50> NewList() {
return new RL_b442351480b89deb6222b9dd043cac65();
}


} // RL_b442351480b89deb6222b9dd043cac65
}

