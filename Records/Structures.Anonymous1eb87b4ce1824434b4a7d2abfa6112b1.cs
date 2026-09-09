namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (THu4HoLhNES0p9Kr+mESsQ)
///  <code>RC_3bc764f67e81a7d7cfa96c1a97a8c95b</code> that represent
/// s <code>ApprovalProcessIdProcessTypeCodeVersionIsSpecialRecord</code> <p>Description: </p>
/// </summary>
// Name: ApprovalProcessIdProcessTypeCodeVersionIsSpecialRecord
public partial struct RC_3bc764f67e81a7d7cfa96c1a97a8c95b : ITypedRecord<RC_3bc764f67e81a7d7cfa96c1a97a8c95b> {
internal static readonly GlobalObjectKey IdApprovalProcessId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*lNzCzyUnLHucSmSu1VawKA");
internal static readonly GlobalObjectKey IdProcessTypeCode = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*5IDRa6gy4CIi8D+uMoGVag");
internal static readonly GlobalObjectKey IdVersion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+UR50Bu0yUDV7FVkGTpYIQ");
internal static readonly GlobalObjectKey IdIsSpecial = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Fz+2jGjuzZHqrvq0SmaR0g");

public long ssApprovalProcessId;

public string ssProcessTypeCode;

public string ssVersion;

public bool ssIsSpecial;


public BitArray OptimizedAttributes;

public RC_3bc764f67e81a7d7cfa96c1a97a8c95b() {
OptimizedAttributes = null;
ssApprovalProcessId = 0L;
ssProcessTypeCode = "";
ssVersion = "";
ssIsSpecial = false;
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
ssApprovalProcessId = r.ReadEntityReferenceLongInteger(index++, "ApprovalProcessIdProcessTypeCodeVersionIsSpecialRecord.ApprovalProcessId", 0L);
ssProcessTypeCode = r.ReadText(index++, "ApprovalProcessIdProcessTypeCodeVersionIsSpecialRecord.ProcessTypeCode", "");
ssVersion = r.ReadText(index++, "ApprovalProcessIdProcessTypeCodeVersionIsSpecialRecord.Version", "");
ssIsSpecial = r.ReadBoolean(index++, "ApprovalProcessIdProcessTypeCodeVersionIsSpecialRecord.IsSpecial", false);
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
public void ReadIM(RC_3bc764f67e81a7d7cfa96c1a97a8c95b r) {
this = r;
}


public static bool operator == (RC_3bc764f67e81a7d7cfa96c1a97a8c95b a, RC_3bc764f67e81a7d7cfa96c1a97a8c95b b) {
if (a.ssApprovalProcessId != b.ssApprovalProcessId) return false;
if (a.ssProcessTypeCode != b.ssProcessTypeCode) return false;
if (a.ssVersion != b.ssVersion) return false;
if (a.ssIsSpecial != b.ssIsSpecial) return false;
return true;
}

public static bool operator != (RC_3bc764f67e81a7d7cfa96c1a97a8c95b a, RC_3bc764f67e81a7d7cfa96c1a97a8c95b b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_3bc764f67e81a7d7cfa96c1a97a8c95b)) return false;
return (this == (RC_3bc764f67e81a7d7cfa96c1a97a8c95b)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssApprovalProcessId.GetHashCode()
 ^ ssProcessTypeCode.GetHashCode()
 ^ ssVersion.GetHashCode()
 ^ ssIsSpecial.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_3bc764f67e81a7d7cfa96c1a97a8c95b Duplicate() {
RC_3bc764f67e81a7d7cfa96c1a97a8c95b t;
t.ssApprovalProcessId = this.ssApprovalProcessId;
t.ssProcessTypeCode = this.ssProcessTypeCode;
t.ssVersion = this.ssVersion;
t.ssIsSpecial = this.ssIsSpecial;
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
if (head == "approvalprocessid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApprovalProcessId")) variable.Value = ssApprovalProcessId; else variable.Optimized = true;
} else if (head == "processtypecode") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProcessTypeCode")) variable.Value = ssProcessTypeCode; else variable.Optimized = true;
} else if (head == "version") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Version")) variable.Value = ssVersion; else variable.Optimized = true;
} else if (head == "isspecial") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsSpecial")) variable.Value = ssIsSpecial; else variable.Optimized = true;
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
if (key == IdApprovalProcessId) {
return ssApprovalProcessId;
}
if (key == IdProcessTypeCode) {
return ssProcessTypeCode;
}
if (key == IdVersion) {
return ssVersion;
}
if (key == IdIsSpecial) {
return ssIsSpecial;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdApprovalProcessId.Key.AsGuid) {
return ssApprovalProcessId;
}
if (attributeKey == IdProcessTypeCode.Key.AsGuid) {
return ssProcessTypeCode;
}
if (attributeKey == IdVersion.Key.AsGuid) {
return ssVersion;
}
if (attributeKey == IdIsSpecial.Key.AsGuid) {
return ssIsSpecial;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssApprovalProcessId = (long) other.AttributeGet(IdApprovalProcessId);
ssProcessTypeCode = (string) other.AttributeGet(IdProcessTypeCode);
ssVersion = (string) other.AttributeGet(IdVersion);
ssIsSpecial = (bool) other.AttributeGet(IdIsSpecial);
}
} // RC_3bc764f67e81a7d7cfa96c1a97a8c95b
/// <summary>
/// RecordList type <code>ApprovalProcessIdProcessTypeCodeVersionIsSpecialRecordList</code> that
///  represents a record list of <code>ApprovalProcessIdentifier, Text, Text, Boolean</code>
/// </summary>
public partial class RL_633369f840fc461502b9393a47e0a287 : GenericRecordList<RC_3bc764f67e81a7d7cfa96c1a97a8c95b>, IEnumerable, IEnumerator {

protected override RC_3bc764f67e81a7d7cfa96c1a97a8c95b GetElementDefaultValue() {
return new RC_3bc764f67e81a7d7cfa96c1a97a8c95b();
}

public T[] ToArray<T>(Func<RC_3bc764f67e81a7d7cfa96c1a97a8c95b, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_633369f840fc461502b9393a47e0a287 recordList, Func<RC_3bc764f67e81a7d7cfa96c1a97a8c95b, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_633369f840fc461502b9393a47e0a287(RC_3bc764f67e81a7d7cfa96c1a97a8c95b[] array) {
  RL_633369f840fc461502b9393a47e0a287 result = new RL_633369f840fc461502b9393a47e0a287();
result.InnerFromArray(array);
    return result;
}

public static RL_633369f840fc461502b9393a47e0a287 ToList<T>(T[] array, Func <T, RC_3bc764f67e81a7d7cfa96c1a97a8c95b> converter) {
  RL_633369f840fc461502b9393a47e0a287 result = new RL_633369f840fc461502b9393a47e0a287();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_633369f840fc461502b9393a47e0a287 FromRestList<T>(RestList<T> restList, Func <T, RC_3bc764f67e81a7d7cfa96c1a97a8c95b> converter) {
  RL_633369f840fc461502b9393a47e0a287 result = new RL_633369f840fc461502b9393a47e0a287();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_633369f840fc461502b9393a47e0a287() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_3bc764f67e81a7d7cfa96c1a97a8c95b> NewList() {
return new RL_633369f840fc461502b9393a47e0a287();
}


} // RL_633369f840fc461502b9393a47e0a287
}

