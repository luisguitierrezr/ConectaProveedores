namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (KK17slBSREm08MT7ZOUzOQ)
///  <code>RC_786401d4272d8830c4a71cf084346ee6</code> that represent
/// s <code>ProposalApprovalLevelIdApplicationRoleNameRecord</code> <p>Description: </p>
/// </summary>
// Name: ProposalApprovalLevelIdApplicationRoleNameRecord
public partial struct RC_786401d4272d8830c4a71cf084346ee6 : ITypedRecord<RC_786401d4272d8830c4a71cf084346ee6> {
internal static readonly GlobalObjectKey IdProposalApprovalLevelId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*sSJYnwLxtvIAkRQX_hs8Rg");
internal static readonly GlobalObjectKey IdApplicationRoleName = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*fh9I1OPOaOT0418HkkZ4AA");

public long ssProposalApprovalLevelId;

public string ssApplicationRoleName;


public BitArray OptimizedAttributes;

public RC_786401d4272d8830c4a71cf084346ee6() {
OptimizedAttributes = null;
ssProposalApprovalLevelId = 0L;
ssApplicationRoleName = "";
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
ssProposalApprovalLevelId = r.ReadEntityReferenceLongInteger(index++, "ProposalApprovalLevelIdApplicationRoleNameRecord.ProposalApprovalLevelId", 0L);
ssApplicationRoleName = r.ReadText(index++, "ProposalApprovalLevelIdApplicationRoleNameRecord.ApplicationRoleName", "");
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
public void ReadIM(RC_786401d4272d8830c4a71cf084346ee6 r) {
this = r;
}


public static bool operator == (RC_786401d4272d8830c4a71cf084346ee6 a, RC_786401d4272d8830c4a71cf084346ee6 b) {
if (a.ssProposalApprovalLevelId != b.ssProposalApprovalLevelId) return false;
if (a.ssApplicationRoleName != b.ssApplicationRoleName) return false;
return true;
}

public static bool operator != (RC_786401d4272d8830c4a71cf084346ee6 a, RC_786401d4272d8830c4a71cf084346ee6 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_786401d4272d8830c4a71cf084346ee6)) return false;
return (this == (RC_786401d4272d8830c4a71cf084346ee6)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssProposalApprovalLevelId.GetHashCode()
 ^ ssApplicationRoleName.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_786401d4272d8830c4a71cf084346ee6 Duplicate() {
RC_786401d4272d8830c4a71cf084346ee6 t;
t.ssProposalApprovalLevelId = this.ssProposalApprovalLevelId;
t.ssApplicationRoleName = this.ssApplicationRoleName;
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
if (head == "proposalapprovallevelid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalApprovalLevelId")) variable.Value = ssProposalApprovalLevelId; else variable.Optimized = true;
} else if (head == "applicationrolename") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApplicationRoleName")) variable.Value = ssApplicationRoleName; else variable.Optimized = true;
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
if (key == IdProposalApprovalLevelId) {
return ssProposalApprovalLevelId;
}
if (key == IdApplicationRoleName) {
return ssApplicationRoleName;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdProposalApprovalLevelId.Key.AsGuid) {
return ssProposalApprovalLevelId;
}
if (attributeKey == IdApplicationRoleName.Key.AsGuid) {
return ssApplicationRoleName;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssProposalApprovalLevelId = (long) other.AttributeGet(IdProposalApprovalLevelId);
ssApplicationRoleName = (string) other.AttributeGet(IdApplicationRoleName);
}
} // RC_786401d4272d8830c4a71cf084346ee6
/// <summary>
/// RecordList type <code>ProposalApprovalLevelIdApplicationRoleNameRecordList</code> that represents a
///  record list of <code>ProposalApprovalLevelIdentifier, Text</code>
/// </summary>
public partial class RL_1de096a2cd5bc9c1d57a6496eba081e9 : GenericRecordList<RC_786401d4272d8830c4a71cf084346ee6>, IEnumerable, IEnumerator {

protected override RC_786401d4272d8830c4a71cf084346ee6 GetElementDefaultValue() {
return new RC_786401d4272d8830c4a71cf084346ee6();
}

public T[] ToArray<T>(Func<RC_786401d4272d8830c4a71cf084346ee6, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_1de096a2cd5bc9c1d57a6496eba081e9 recordList, Func<RC_786401d4272d8830c4a71cf084346ee6, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_1de096a2cd5bc9c1d57a6496eba081e9(RC_786401d4272d8830c4a71cf084346ee6[] array) {
  RL_1de096a2cd5bc9c1d57a6496eba081e9 result = new RL_1de096a2cd5bc9c1d57a6496eba081e9();
result.InnerFromArray(array);
    return result;
}

public static RL_1de096a2cd5bc9c1d57a6496eba081e9 ToList<T>(T[] array, Func <T, RC_786401d4272d8830c4a71cf084346ee6> converter) {
  RL_1de096a2cd5bc9c1d57a6496eba081e9 result = new RL_1de096a2cd5bc9c1d57a6496eba081e9();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_1de096a2cd5bc9c1d57a6496eba081e9 FromRestList<T>(RestList<T> restList, Func <T, RC_786401d4272d8830c4a71cf084346ee6> converter) {
  RL_1de096a2cd5bc9c1d57a6496eba081e9 result = new RL_1de096a2cd5bc9c1d57a6496eba081e9();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_1de096a2cd5bc9c1d57a6496eba081e9() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_786401d4272d8830c4a71cf084346ee6> NewList() {
return new RL_1de096a2cd5bc9c1d57a6496eba081e9();
}


} // RL_1de096a2cd5bc9c1d57a6496eba081e9
}

