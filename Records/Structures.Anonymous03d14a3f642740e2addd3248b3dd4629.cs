namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (P0rRAydk4kCt3TJIs91GKQ)
///  <code>RC_0be8bae4cc285c0288822b663818cb6c</code> that represent
/// s <code>FolioApprovalLevelRecord</code> <p>Description: </p>
/// </summary>
// Name: FolioApprovalLevelRecord
public partial struct RC_0be8bae4cc285c0288822b663818cb6c : ITypedRecord<RC_0be8bae4cc285c0288822b663818cb6c> {
internal static readonly GlobalObjectKey IdFolioApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*5LroCyjMAlyIgitmOBjLbA");

public EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord ssENFolioApprovalLevel;


public static implicit operator EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord( RC_0be8bae4cc285c0288822b663818cb6c r) {
return r.ssENFolioApprovalLevel;
}

public static implicit operator RC_0be8bae4cc285c0288822b663818cb6c (EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord r) {
RC_0be8bae4cc285c0288822b663818cb6c res = new RC_0be8bae4cc285c0288822b663818cb6c ();
res.ssENFolioApprovalLevel = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENFolioApprovalLevel.ChangedAttributes = value;
}
get {
    return ssENFolioApprovalLevel.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_0be8bae4cc285c0288822b663818cb6c() {
OptimizedAttributes = null;
ssENFolioApprovalLevel = new EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(20,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENFolioApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENFolioApprovalLevel.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENFolioApprovalLevel.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENFolioApprovalLevel.Read( r, ref index);
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
public void ReadIM(RC_0be8bae4cc285c0288822b663818cb6c r) {
this = r;
}


public static bool operator == (RC_0be8bae4cc285c0288822b663818cb6c a, RC_0be8bae4cc285c0288822b663818cb6c b) {
if (a.ssENFolioApprovalLevel != b.ssENFolioApprovalLevel) return false;
return true;
}

public static bool operator != (RC_0be8bae4cc285c0288822b663818cb6c a, RC_0be8bae4cc285c0288822b663818cb6c b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_0be8bae4cc285c0288822b663818cb6c)) return false;
return (this == (RC_0be8bae4cc285c0288822b663818cb6c)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENFolioApprovalLevel.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENFolioApprovalLevel.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENFolioApprovalLevel.InternalRecursiveSave();
}


public RC_0be8bae4cc285c0288822b663818cb6c Duplicate() {
RC_0be8bae4cc285c0288822b663818cb6c t;
t.ssENFolioApprovalLevel = (EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord)this.ssENFolioApprovalLevel.Duplicate();
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
if (head == "folioapprovallevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioApprovalLevel")) variable.Value = ssENFolioApprovalLevel; else variable.Optimized = true;
variable.SetFieldName("folioapprovallevel");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENFolioApprovalLevel.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENFolioApprovalLevel.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdFolioApprovalLevel) {
return ssENFolioApprovalLevel;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFolioApprovalLevel.Key.AsGuid) {
return ssENFolioApprovalLevel;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENFolioApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdFolioApprovalLevel));
}
} // RC_0be8bae4cc285c0288822b663818cb6c
/// <summary>
/// RecordList type <code>FolioApprovalLevelRecordList</code> that represents a record list of
///  <code>FolioApprovalLevel</code>
/// </summary>
public partial class RL_ecaf6a267327a661b83be973ba99d46b : GenericRecordList<RC_0be8bae4cc285c0288822b663818cb6c>, IEnumerable, IEnumerator {

protected override RC_0be8bae4cc285c0288822b663818cb6c GetElementDefaultValue() {
return new RC_0be8bae4cc285c0288822b663818cb6c();
}

public T[] ToArray<T>(Func<RC_0be8bae4cc285c0288822b663818cb6c, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ecaf6a267327a661b83be973ba99d46b recordList, Func<RC_0be8bae4cc285c0288822b663818cb6c, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ecaf6a267327a661b83be973ba99d46b(RC_0be8bae4cc285c0288822b663818cb6c[] array) {
  RL_ecaf6a267327a661b83be973ba99d46b result = new RL_ecaf6a267327a661b83be973ba99d46b();
result.InnerFromArray(array);
    return result;
}

public static RL_ecaf6a267327a661b83be973ba99d46b ToList<T>(T[] array, Func <T, RC_0be8bae4cc285c0288822b663818cb6c> converter) {
  RL_ecaf6a267327a661b83be973ba99d46b result = new RL_ecaf6a267327a661b83be973ba99d46b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ecaf6a267327a661b83be973ba99d46b FromRestList<T>(RestList<T> restList, Func <T, RC_0be8bae4cc285c0288822b663818cb6c> converter) {
  RL_ecaf6a267327a661b83be973ba99d46b result = new RL_ecaf6a267327a661b83be973ba99d46b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ecaf6a267327a661b83be973ba99d46b() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(20,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_0be8bae4cc285c0288822b663818cb6c> NewList() {
return new RL_ecaf6a267327a661b83be973ba99d46b();
}


} // RL_ecaf6a267327a661b83be973ba99d46b
}

