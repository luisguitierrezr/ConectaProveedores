namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (X0rBrPVc70CcvWxykPaGnA)
///  <code>RC_474c5c8cc36282ebfc11b03838b11802</code> that represent
/// s <code>ProposalIdProposalLineApprovalLevelIdRecord</code> <p>Description: </p>
/// </summary>
// Name: ProposalIdProposalLineApprovalLevelIdRecord
public partial struct RC_474c5c8cc36282ebfc11b03838b11802 : ITypedRecord<RC_474c5c8cc36282ebfc11b03838b11802> {
internal static readonly GlobalObjectKey IdProposalId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*qaHPPBtO29SCFj_aF3steQ");
internal static readonly GlobalObjectKey IdProposalLineApprovalLevelId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*U0shnrW6ZgSVJlWQipEsZw");

public long ssProposalId;

public long ssProposalLineApprovalLevelId;


public BitArray OptimizedAttributes;

public RC_474c5c8cc36282ebfc11b03838b11802() {
OptimizedAttributes = null;
ssProposalId = 0L;
ssProposalLineApprovalLevelId = 0L;
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
ssProposalId = r.ReadEntityReferenceLongInteger(index++, "ProposalIdProposalLineApprovalLevelIdRecord.ProposalId", 0L);
ssProposalLineApprovalLevelId = r.ReadEntityReferenceLongInteger(index++, "ProposalIdProposalLineApprovalLevelIdRecord.ProposalLineApprovalLevelId", 0L);
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
public void ReadIM(RC_474c5c8cc36282ebfc11b03838b11802 r) {
this = r;
}


public static bool operator == (RC_474c5c8cc36282ebfc11b03838b11802 a, RC_474c5c8cc36282ebfc11b03838b11802 b) {
if (a.ssProposalId != b.ssProposalId) return false;
if (a.ssProposalLineApprovalLevelId != b.ssProposalLineApprovalLevelId) return false;
return true;
}

public static bool operator != (RC_474c5c8cc36282ebfc11b03838b11802 a, RC_474c5c8cc36282ebfc11b03838b11802 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_474c5c8cc36282ebfc11b03838b11802)) return false;
return (this == (RC_474c5c8cc36282ebfc11b03838b11802)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssProposalId.GetHashCode()
 ^ ssProposalLineApprovalLevelId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_474c5c8cc36282ebfc11b03838b11802 Duplicate() {
RC_474c5c8cc36282ebfc11b03838b11802 t;
t.ssProposalId = this.ssProposalId;
t.ssProposalLineApprovalLevelId = this.ssProposalLineApprovalLevelId;
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
if (head == "proposalid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalId")) variable.Value = ssProposalId; else variable.Optimized = true;
} else if (head == "proposallineapprovallevelid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalLineApprovalLevelId")) variable.Value = ssProposalLineApprovalLevelId; else variable.Optimized = true;
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
if (key == IdProposalId) {
return ssProposalId;
}
if (key == IdProposalLineApprovalLevelId) {
return ssProposalLineApprovalLevelId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdProposalId.Key.AsGuid) {
return ssProposalId;
}
if (attributeKey == IdProposalLineApprovalLevelId.Key.AsGuid) {
return ssProposalLineApprovalLevelId;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssProposalId = (long) other.AttributeGet(IdProposalId);
ssProposalLineApprovalLevelId = (long) other.AttributeGet(IdProposalLineApprovalLevelId);
}
} // RC_474c5c8cc36282ebfc11b03838b11802
/// <summary>
/// RecordList type <code>ProposalIdProposalLineApprovalLevelIdRecordList</code> that represents a
///  record list of <code>ProposalIdentifier, ProposalLineApprovalLevelIdentifier</code>
/// </summary>
public partial class RL_b8bc07441a220c1a5fc88aead339c457 : GenericRecordList<RC_474c5c8cc36282ebfc11b03838b11802>, IEnumerable, IEnumerator {

protected override RC_474c5c8cc36282ebfc11b03838b11802 GetElementDefaultValue() {
return new RC_474c5c8cc36282ebfc11b03838b11802();
}

public T[] ToArray<T>(Func<RC_474c5c8cc36282ebfc11b03838b11802, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_b8bc07441a220c1a5fc88aead339c457 recordList, Func<RC_474c5c8cc36282ebfc11b03838b11802, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_b8bc07441a220c1a5fc88aead339c457(RC_474c5c8cc36282ebfc11b03838b11802[] array) {
  RL_b8bc07441a220c1a5fc88aead339c457 result = new RL_b8bc07441a220c1a5fc88aead339c457();
result.InnerFromArray(array);
    return result;
}

public static RL_b8bc07441a220c1a5fc88aead339c457 ToList<T>(T[] array, Func <T, RC_474c5c8cc36282ebfc11b03838b11802> converter) {
  RL_b8bc07441a220c1a5fc88aead339c457 result = new RL_b8bc07441a220c1a5fc88aead339c457();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_b8bc07441a220c1a5fc88aead339c457 FromRestList<T>(RestList<T> restList, Func <T, RC_474c5c8cc36282ebfc11b03838b11802> converter) {
  RL_b8bc07441a220c1a5fc88aead339c457 result = new RL_b8bc07441a220c1a5fc88aead339c457();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_b8bc07441a220c1a5fc88aead339c457() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_474c5c8cc36282ebfc11b03838b11802> NewList() {
return new RL_b8bc07441a220c1a5fc88aead339c457();
}


} // RL_b8bc07441a220c1a5fc88aead339c457
}

