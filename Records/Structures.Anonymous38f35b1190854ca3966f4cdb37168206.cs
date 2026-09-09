namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (EVvzOIWQo0yWb0zbNxaCBg)
///  <code>RC_1e039122eac73163e52e6371e4a4643a</code> that represent
/// s <code>AuditProposalsReportExportStructRecord</code> <p>Description: </p>
/// </summary>
// Name: AuditProposalsReportExportStructRecord
public partial struct RC_1e039122eac73163e52e6371e4a4643a : ITypedRecord<RC_1e039122eac73163e52e6371e4a4643a> {
internal static readonly GlobalObjectKey IdAuditProposalsReportExportStruct = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*IpEDHsfqYzHlLmNx5KRkOg");

public ST_003b164d236e27fa4a14d14a7514101cStructure ssSTAuditProposalsReportExportStruct;


public static implicit operator ST_003b164d236e27fa4a14d14a7514101cStructure( RC_1e039122eac73163e52e6371e4a4643a r) {
return r.ssSTAuditProposalsReportExportStruct;
}

public static implicit operator RC_1e039122eac73163e52e6371e4a4643a (ST_003b164d236e27fa4a14d14a7514101cStructure r) {
RC_1e039122eac73163e52e6371e4a4643a res = new RC_1e039122eac73163e52e6371e4a4643a ();
res.ssSTAuditProposalsReportExportStruct = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_1e039122eac73163e52e6371e4a4643a() {
OptimizedAttributes = null;
ssSTAuditProposalsReportExportStruct = new ST_003b164d236e27fa4a14d14a7514101cStructure();
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
    ssSTAuditProposalsReportExportStruct.OptimizedAttributes = value[0];
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
ssSTAuditProposalsReportExportStruct.Read( r, ref index);
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
public void ReadIM(RC_1e039122eac73163e52e6371e4a4643a r) {
this = r;
}


public static bool operator == (RC_1e039122eac73163e52e6371e4a4643a a, RC_1e039122eac73163e52e6371e4a4643a b) {
if (a.ssSTAuditProposalsReportExportStruct != b.ssSTAuditProposalsReportExportStruct) return false;
return true;
}

public static bool operator != (RC_1e039122eac73163e52e6371e4a4643a a, RC_1e039122eac73163e52e6371e4a4643a b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_1e039122eac73163e52e6371e4a4643a)) return false;
return (this == (RC_1e039122eac73163e52e6371e4a4643a)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTAuditProposalsReportExportStruct.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTAuditProposalsReportExportStruct.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTAuditProposalsReportExportStruct.InternalRecursiveSave();
}


public RC_1e039122eac73163e52e6371e4a4643a Duplicate() {
RC_1e039122eac73163e52e6371e4a4643a t;
t.ssSTAuditProposalsReportExportStruct = (ST_003b164d236e27fa4a14d14a7514101cStructure)this.ssSTAuditProposalsReportExportStruct.Duplicate();
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
if (head == "auditproposalsreportexportstruct") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AuditProposalsReportExportStruct")) variable.Value = ssSTAuditProposalsReportExportStruct; else variable.Optimized = true;
variable.SetFieldName("auditproposalsreportexportstruct");
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
if (key == IdAuditProposalsReportExportStruct) {
return ssSTAuditProposalsReportExportStruct;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdAuditProposalsReportExportStruct.Key.AsGuid) {
return ssSTAuditProposalsReportExportStruct;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTAuditProposalsReportExportStruct.FillFromOther((IRecord) other.AttributeGet(IdAuditProposalsReportExportStruct));
}
} // RC_1e039122eac73163e52e6371e4a4643a
/// <summary>
/// RecordList type <code>AuditProposalsReportExportStructRecordList</code> that represents a record
///  list of <code>AuditProposalsReportExportStruct</code>
/// </summary>
public partial class RL_ac6f2bf176d0c2d218c3125f52f96430 : GenericRecordList<RC_1e039122eac73163e52e6371e4a4643a>, IEnumerable, IEnumerator {

protected override RC_1e039122eac73163e52e6371e4a4643a GetElementDefaultValue() {
return new RC_1e039122eac73163e52e6371e4a4643a();
}

public T[] ToArray<T>(Func<RC_1e039122eac73163e52e6371e4a4643a, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ac6f2bf176d0c2d218c3125f52f96430 recordList, Func<RC_1e039122eac73163e52e6371e4a4643a, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ac6f2bf176d0c2d218c3125f52f96430(RC_1e039122eac73163e52e6371e4a4643a[] array) {
  RL_ac6f2bf176d0c2d218c3125f52f96430 result = new RL_ac6f2bf176d0c2d218c3125f52f96430();
result.InnerFromArray(array);
    return result;
}

public static RL_ac6f2bf176d0c2d218c3125f52f96430 ToList<T>(T[] array, Func <T, RC_1e039122eac73163e52e6371e4a4643a> converter) {
  RL_ac6f2bf176d0c2d218c3125f52f96430 result = new RL_ac6f2bf176d0c2d218c3125f52f96430();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ac6f2bf176d0c2d218c3125f52f96430 FromRestList<T>(RestList<T> restList, Func <T, RC_1e039122eac73163e52e6371e4a4643a> converter) {
  RL_ac6f2bf176d0c2d218c3125f52f96430 result = new RL_ac6f2bf176d0c2d218c3125f52f96430();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ac6f2bf176d0c2d218c3125f52f96430() : base() {
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
protected override OSList<RC_1e039122eac73163e52e6371e4a4643a> NewList() {
return new RL_ac6f2bf176d0c2d218c3125f52f96430();
}


} // RL_ac6f2bf176d0c2d218c3125f52f96430
}

