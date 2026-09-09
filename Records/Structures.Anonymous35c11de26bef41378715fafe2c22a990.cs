namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (4h3BNe9rN0GHFfr+LCKpkA)
///  <code>RC_5327da8894a76849e4ef5a737a86e7d3</code> that represent
/// s <code>ProposalApprovalLevelProposalLineApprovalLevelRecord</code> <p>Description: </p>
/// </summary>
// Name: ProposalApprovalLevelProposalLineApprovalLevelRecord
public partial struct RC_5327da8894a76849e4ef5a737a86e7d3 : ITypedRecord<RC_5327da8894a76849e4ef5a737a86e7d3> {
internal static readonly GlobalObjectKey IdProposalApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*eJqSVc+Lx3kjVPxJFgrMDA");
internal static readonly GlobalObjectKey IdProposalLineApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*XbRfhyNBH6nOg4MfD1VNjg");

public EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord ssENProposalApprovalLevel;

public EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord ssENProposalLineApprovalLevel;


public BitArray OptimizedAttributes;

public RC_5327da8894a76849e4ef5a737a86e7d3() {
OptimizedAttributes = null;
ssENProposalApprovalLevel = new EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord();
ssENProposalLineApprovalLevel = new EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(7,false);
    all[1] = new BitArray(9,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENProposalApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENProposalLineApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENProposalApprovalLevel.OptimizedAttributes = value[0];
    ssENProposalLineApprovalLevel.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENProposalApprovalLevel.OptimizedAttributes;
    all[1] = ssENProposalLineApprovalLevel.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENProposalApprovalLevel.Read( r, ref index);
ssENProposalLineApprovalLevel.Read( r, ref index);
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
public void ReadIM(RC_5327da8894a76849e4ef5a737a86e7d3 r) {
this = r;
}


public static bool operator == (RC_5327da8894a76849e4ef5a737a86e7d3 a, RC_5327da8894a76849e4ef5a737a86e7d3 b) {
if (a.ssENProposalApprovalLevel != b.ssENProposalApprovalLevel) return false;
if (a.ssENProposalLineApprovalLevel != b.ssENProposalLineApprovalLevel) return false;
return true;
}

public static bool operator != (RC_5327da8894a76849e4ef5a737a86e7d3 a, RC_5327da8894a76849e4ef5a737a86e7d3 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_5327da8894a76849e4ef5a737a86e7d3)) return false;
return (this == (RC_5327da8894a76849e4ef5a737a86e7d3)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENProposalApprovalLevel.GetHashCode()
 ^ ssENProposalLineApprovalLevel.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENProposalApprovalLevel.RecursiveReset();
ssENProposalLineApprovalLevel.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENProposalApprovalLevel.InternalRecursiveSave();
ssENProposalLineApprovalLevel.InternalRecursiveSave();
}


public RC_5327da8894a76849e4ef5a737a86e7d3 Duplicate() {
RC_5327da8894a76849e4ef5a737a86e7d3 t;
t.ssENProposalApprovalLevel = (EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord)this.ssENProposalApprovalLevel.Duplicate();
t.ssENProposalLineApprovalLevel = (EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord)this.ssENProposalLineApprovalLevel.Duplicate();
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
if (head == "proposalapprovallevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalApprovalLevel")) variable.Value = ssENProposalApprovalLevel; else variable.Optimized = true;
variable.SetFieldName("proposalapprovallevel");
} else if (head == "proposallineapprovallevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalLineApprovalLevel")) variable.Value = ssENProposalLineApprovalLevel; else variable.Optimized = true;
variable.SetFieldName("proposallineapprovallevel");
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
if (key == IdProposalApprovalLevel) {
return ssENProposalApprovalLevel;
}
if (key == IdProposalLineApprovalLevel) {
return ssENProposalLineApprovalLevel;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdProposalApprovalLevel.Key.AsGuid) {
return ssENProposalApprovalLevel;
}
if (attributeKey == IdProposalLineApprovalLevel.Key.AsGuid) {
return ssENProposalLineApprovalLevel;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENProposalApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdProposalApprovalLevel));
ssENProposalLineApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdProposalLineApprovalLevel));
}
} // RC_5327da8894a76849e4ef5a737a86e7d3
/// <summary>
/// RecordList type <code>ProposalApprovalLevelProposalLineApprovalLevelRecordList</code> that
///  represents a record list of <code>ProposalApprovalLevel, ProposalLineApprovalLevel</code>
/// </summary>
public partial class RL_e23a8e9d8d827e81e0e0449c363a37eb : GenericRecordList<RC_5327da8894a76849e4ef5a737a86e7d3>, IEnumerable, IEnumerator {

protected override RC_5327da8894a76849e4ef5a737a86e7d3 GetElementDefaultValue() {
return new RC_5327da8894a76849e4ef5a737a86e7d3();
}

public T[] ToArray<T>(Func<RC_5327da8894a76849e4ef5a737a86e7d3, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e23a8e9d8d827e81e0e0449c363a37eb recordList, Func<RC_5327da8894a76849e4ef5a737a86e7d3, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e23a8e9d8d827e81e0e0449c363a37eb(RC_5327da8894a76849e4ef5a737a86e7d3[] array) {
  RL_e23a8e9d8d827e81e0e0449c363a37eb result = new RL_e23a8e9d8d827e81e0e0449c363a37eb();
result.InnerFromArray(array);
    return result;
}

public static RL_e23a8e9d8d827e81e0e0449c363a37eb ToList<T>(T[] array, Func <T, RC_5327da8894a76849e4ef5a737a86e7d3> converter) {
  RL_e23a8e9d8d827e81e0e0449c363a37eb result = new RL_e23a8e9d8d827e81e0e0449c363a37eb();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e23a8e9d8d827e81e0e0449c363a37eb FromRestList<T>(RestList<T> restList, Func <T, RC_5327da8894a76849e4ef5a737a86e7d3> converter) {
  RL_e23a8e9d8d827e81e0e0449c363a37eb result = new RL_e23a8e9d8d827e81e0e0449c363a37eb();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e23a8e9d8d827e81e0e0449c363a37eb() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(7,false);
def[1] = new BitArray(9,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_5327da8894a76849e4ef5a737a86e7d3> NewList() {
return new RL_e23a8e9d8d827e81e0e0449c363a37eb();
}


} // RL_e23a8e9d8d827e81e0e0449c363a37eb
}

