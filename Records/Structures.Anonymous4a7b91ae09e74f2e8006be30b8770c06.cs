namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (rpF7SucJLk+ABr4wuHcMBg)
///  <code>RC_6041e483640e901fd2a96b2a9af2a903</code> that represent
/// s <code>FolioApprovalLevelIdFolioIdFolioNumberRecord</code> <p>Description: </p>
/// </summary>
// Name: FolioApprovalLevelIdFolioIdFolioNumberRecord
public partial struct RC_6041e483640e901fd2a96b2a9af2a903 : ITypedRecord<RC_6041e483640e901fd2a96b2a9af2a903> {
internal static readonly GlobalObjectKey IdFolioApprovalLevelId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*xHOtl7qv1O+4fKhdxVbTNg");
internal static readonly GlobalObjectKey IdFolioId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*P1AUSm_kXl9bz1uqi7lOGQ");
internal static readonly GlobalObjectKey IdFolioNumber = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*wHrgzfg8mDQ6ZXlaAbJDlQ");

public long ssFolioApprovalLevelId;

public long ssFolioId;

public string ssFolioNumber;


public BitArray OptimizedAttributes;

public RC_6041e483640e901fd2a96b2a9af2a903() {
OptimizedAttributes = null;
ssFolioApprovalLevelId = 0L;
ssFolioId = 0L;
ssFolioNumber = "";
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
ssFolioApprovalLevelId = r.ReadEntityReferenceLongInteger(index++, "FolioApprovalLevelIdFolioIdFolioNumberRecord.FolioApprovalLevelId", 0L);
ssFolioId = r.ReadEntityReferenceLongInteger(index++, "FolioApprovalLevelIdFolioIdFolioNumberRecord.FolioId", 0L);
ssFolioNumber = r.ReadText(index++, "FolioApprovalLevelIdFolioIdFolioNumberRecord.FolioNumber", "");
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
public void ReadIM(RC_6041e483640e901fd2a96b2a9af2a903 r) {
this = r;
}


public static bool operator == (RC_6041e483640e901fd2a96b2a9af2a903 a, RC_6041e483640e901fd2a96b2a9af2a903 b) {
if (a.ssFolioApprovalLevelId != b.ssFolioApprovalLevelId) return false;
if (a.ssFolioId != b.ssFolioId) return false;
if (a.ssFolioNumber != b.ssFolioNumber) return false;
return true;
}

public static bool operator != (RC_6041e483640e901fd2a96b2a9af2a903 a, RC_6041e483640e901fd2a96b2a9af2a903 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_6041e483640e901fd2a96b2a9af2a903)) return false;
return (this == (RC_6041e483640e901fd2a96b2a9af2a903)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssFolioApprovalLevelId.GetHashCode()
 ^ ssFolioId.GetHashCode()
 ^ ssFolioNumber.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_6041e483640e901fd2a96b2a9af2a903 Duplicate() {
RC_6041e483640e901fd2a96b2a9af2a903 t;
t.ssFolioApprovalLevelId = this.ssFolioApprovalLevelId;
t.ssFolioId = this.ssFolioId;
t.ssFolioNumber = this.ssFolioNumber;
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
if (head == "folioapprovallevelid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioApprovalLevelId")) variable.Value = ssFolioApprovalLevelId; else variable.Optimized = true;
} else if (head == "folioid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioId")) variable.Value = ssFolioId; else variable.Optimized = true;
} else if (head == "folionumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioNumber")) variable.Value = ssFolioNumber; else variable.Optimized = true;
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
if (key == IdFolioApprovalLevelId) {
return ssFolioApprovalLevelId;
}
if (key == IdFolioId) {
return ssFolioId;
}
if (key == IdFolioNumber) {
return ssFolioNumber;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFolioApprovalLevelId.Key.AsGuid) {
return ssFolioApprovalLevelId;
}
if (attributeKey == IdFolioId.Key.AsGuid) {
return ssFolioId;
}
if (attributeKey == IdFolioNumber.Key.AsGuid) {
return ssFolioNumber;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssFolioApprovalLevelId = (long) other.AttributeGet(IdFolioApprovalLevelId);
ssFolioId = (long) other.AttributeGet(IdFolioId);
ssFolioNumber = (string) other.AttributeGet(IdFolioNumber);
}
} // RC_6041e483640e901fd2a96b2a9af2a903
/// <summary>
/// RecordList type <code>FolioApprovalLevelIdFolioIdFolioNumberRecordList</code> that represents a
///  record list of <code>FolioApprovalLevelIdentifier, FolioIdentifier, Text</code>
/// </summary>
public partial class RL_79ea8920a52237936a05ba9320d22c38 : GenericRecordList<RC_6041e483640e901fd2a96b2a9af2a903>, IEnumerable, IEnumerator {

protected override RC_6041e483640e901fd2a96b2a9af2a903 GetElementDefaultValue() {
return new RC_6041e483640e901fd2a96b2a9af2a903();
}

public T[] ToArray<T>(Func<RC_6041e483640e901fd2a96b2a9af2a903, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_79ea8920a52237936a05ba9320d22c38 recordList, Func<RC_6041e483640e901fd2a96b2a9af2a903, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_79ea8920a52237936a05ba9320d22c38(RC_6041e483640e901fd2a96b2a9af2a903[] array) {
  RL_79ea8920a52237936a05ba9320d22c38 result = new RL_79ea8920a52237936a05ba9320d22c38();
result.InnerFromArray(array);
    return result;
}

public static RL_79ea8920a52237936a05ba9320d22c38 ToList<T>(T[] array, Func <T, RC_6041e483640e901fd2a96b2a9af2a903> converter) {
  RL_79ea8920a52237936a05ba9320d22c38 result = new RL_79ea8920a52237936a05ba9320d22c38();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_79ea8920a52237936a05ba9320d22c38 FromRestList<T>(RestList<T> restList, Func <T, RC_6041e483640e901fd2a96b2a9af2a903> converter) {
  RL_79ea8920a52237936a05ba9320d22c38 result = new RL_79ea8920a52237936a05ba9320d22c38();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_79ea8920a52237936a05ba9320d22c38() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_6041e483640e901fd2a96b2a9af2a903> NewList() {
return new RL_79ea8920a52237936a05ba9320d22c38();
}


} // RL_79ea8920a52237936a05ba9320d22c38
}

