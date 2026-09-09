namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (C7eFcKs2dk6UAdNOOnVYSg)
///  <code>RC_c75df7b2e7c6e74a3a45dda7bd7b93e2</code> that represents <code>FolioStatusRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: FolioStatusRecord
public partial struct RC_c75df7b2e7c6e74a3a45dda7bd7b93e2 : ITypedRecord<RC_c75df7b2e7c6e74a3a45dda7bd7b93e2> {
internal static readonly GlobalObjectKey IdFolioStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*svddx8bnSuc6Rd2nvXuT4g");

public EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord ssENFolioStatus;


public static implicit operator EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord( RC_c75df7b2e7c6e74a3a45dda7bd7b93e2 r) {
return r.ssENFolioStatus;
}

public static implicit operator RC_c75df7b2e7c6e74a3a45dda7bd7b93e2 (EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord r) {
RC_c75df7b2e7c6e74a3a45dda7bd7b93e2 res = new RC_c75df7b2e7c6e74a3a45dda7bd7b93e2 ();
res.ssENFolioStatus = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENFolioStatus.ChangedAttributes = value;
}
get {
    return ssENFolioStatus.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_c75df7b2e7c6e74a3a45dda7bd7b93e2() {
OptimizedAttributes = null;
ssENFolioStatus = new EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(6,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENFolioStatus.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENFolioStatus.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENFolioStatus.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENFolioStatus.Read( r, ref index);
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
public void ReadIM(RC_c75df7b2e7c6e74a3a45dda7bd7b93e2 r) {
this = r;
}


public static bool operator == (RC_c75df7b2e7c6e74a3a45dda7bd7b93e2 a, RC_c75df7b2e7c6e74a3a45dda7bd7b93e2 b) {
if (a.ssENFolioStatus != b.ssENFolioStatus) return false;
return true;
}

public static bool operator != (RC_c75df7b2e7c6e74a3a45dda7bd7b93e2 a, RC_c75df7b2e7c6e74a3a45dda7bd7b93e2 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_c75df7b2e7c6e74a3a45dda7bd7b93e2)) return false;
return (this == (RC_c75df7b2e7c6e74a3a45dda7bd7b93e2)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENFolioStatus.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENFolioStatus.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENFolioStatus.InternalRecursiveSave();
}


public RC_c75df7b2e7c6e74a3a45dda7bd7b93e2 Duplicate() {
RC_c75df7b2e7c6e74a3a45dda7bd7b93e2 t;
t.ssENFolioStatus = (EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord)this.ssENFolioStatus.Duplicate();
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
if (head == "foliostatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioStatus")) variable.Value = ssENFolioStatus; else variable.Optimized = true;
variable.SetFieldName("foliostatus");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENFolioStatus.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENFolioStatus.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdFolioStatus) {
return ssENFolioStatus;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFolioStatus.Key.AsGuid) {
return ssENFolioStatus;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENFolioStatus.FillFromOther((IRecord) other.AttributeGet(IdFolioStatus));
}
} // RC_c75df7b2e7c6e74a3a45dda7bd7b93e2
/// <summary>
/// RecordList type <code>FolioStatusRecordList</code> that represents a record list of
///  <code>FolioStatus</code>
/// </summary>
public partial class RL_ba9fc810801f4aabee0bc4ef3685a9dd : GenericRecordList<RC_c75df7b2e7c6e74a3a45dda7bd7b93e2>, IEnumerable, IEnumerator {

protected override RC_c75df7b2e7c6e74a3a45dda7bd7b93e2 GetElementDefaultValue() {
return new RC_c75df7b2e7c6e74a3a45dda7bd7b93e2();
}

public T[] ToArray<T>(Func<RC_c75df7b2e7c6e74a3a45dda7bd7b93e2, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ba9fc810801f4aabee0bc4ef3685a9dd recordList, Func<RC_c75df7b2e7c6e74a3a45dda7bd7b93e2, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ba9fc810801f4aabee0bc4ef3685a9dd(RC_c75df7b2e7c6e74a3a45dda7bd7b93e2[] array) {
  RL_ba9fc810801f4aabee0bc4ef3685a9dd result = new RL_ba9fc810801f4aabee0bc4ef3685a9dd();
result.InnerFromArray(array);
    return result;
}

public static RL_ba9fc810801f4aabee0bc4ef3685a9dd ToList<T>(T[] array, Func <T, RC_c75df7b2e7c6e74a3a45dda7bd7b93e2> converter) {
  RL_ba9fc810801f4aabee0bc4ef3685a9dd result = new RL_ba9fc810801f4aabee0bc4ef3685a9dd();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ba9fc810801f4aabee0bc4ef3685a9dd FromRestList<T>(RestList<T> restList, Func <T, RC_c75df7b2e7c6e74a3a45dda7bd7b93e2> converter) {
  RL_ba9fc810801f4aabee0bc4ef3685a9dd result = new RL_ba9fc810801f4aabee0bc4ef3685a9dd();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ba9fc810801f4aabee0bc4ef3685a9dd() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(6,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_c75df7b2e7c6e74a3a45dda7bd7b93e2> NewList() {
return new RL_ba9fc810801f4aabee0bc4ef3685a9dd();
}


} // RL_ba9fc810801f4aabee0bc4ef3685a9dd
}

