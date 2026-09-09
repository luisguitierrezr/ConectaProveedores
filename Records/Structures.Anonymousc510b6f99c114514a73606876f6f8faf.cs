namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (+bYQxRGcFEWnNgaHb2+Prw)
///  <code>RC_90af34fed2114347870a398404753d70</code> that represent
/// s <code>ProposalApprovalLevelProposalLineApprovalLevelProposalLineRecord</code> <p>Description:
///  </p>
/// </summary>
// Name: ProposalApprovalLevelProposalLineApprovalLevelProposalLineRecord
public partial struct RC_90af34fed2114347870a398404753d70 : ITypedRecord<RC_90af34fed2114347870a398404753d70> {
internal static readonly GlobalObjectKey IdProposalApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*eJqSVc+Lx3kjVPxJFgrMDA");
internal static readonly GlobalObjectKey IdProposalLineApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*XbRfhyNBH6nOg4MfD1VNjg");
internal static readonly GlobalObjectKey IdProposalLine = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Ejn_ywl2+KAwstNJSNHAGQ");

public EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord ssENProposalApprovalLevel;

public EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord ssENProposalLineApprovalLevel;

public EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord ssENProposalLine;


public BitArray OptimizedAttributes;

public RC_90af34fed2114347870a398404753d70() {
OptimizedAttributes = null;
ssENProposalApprovalLevel = new EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord();
ssENProposalLineApprovalLevel = new EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord();
ssENProposalLine = new EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(7,false);
    all[1] = new BitArray(9,false);
    all[2] = new BitArray(28,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENProposalApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENProposalLineApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENProposalLine.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENProposalApprovalLevel.OptimizedAttributes = value[0];
    ssENProposalLineApprovalLevel.OptimizedAttributes = value[1];
    ssENProposalLine.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENProposalApprovalLevel.OptimizedAttributes;
    all[1] = ssENProposalLineApprovalLevel.OptimizedAttributes;
    all[2] = ssENProposalLine.OptimizedAttributes;
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
ssENProposalLine.Read( r, ref index);
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
public void ReadIM(RC_90af34fed2114347870a398404753d70 r) {
this = r;
}


public static bool operator == (RC_90af34fed2114347870a398404753d70 a, RC_90af34fed2114347870a398404753d70 b) {
if (a.ssENProposalApprovalLevel != b.ssENProposalApprovalLevel) return false;
if (a.ssENProposalLineApprovalLevel != b.ssENProposalLineApprovalLevel) return false;
if (a.ssENProposalLine != b.ssENProposalLine) return false;
return true;
}

public static bool operator != (RC_90af34fed2114347870a398404753d70 a, RC_90af34fed2114347870a398404753d70 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_90af34fed2114347870a398404753d70)) return false;
return (this == (RC_90af34fed2114347870a398404753d70)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENProposalApprovalLevel.GetHashCode()
 ^ ssENProposalLineApprovalLevel.GetHashCode()
 ^ ssENProposalLine.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENProposalApprovalLevel.RecursiveReset();
ssENProposalLineApprovalLevel.RecursiveReset();
ssENProposalLine.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENProposalApprovalLevel.InternalRecursiveSave();
ssENProposalLineApprovalLevel.InternalRecursiveSave();
ssENProposalLine.InternalRecursiveSave();
}


public RC_90af34fed2114347870a398404753d70 Duplicate() {
RC_90af34fed2114347870a398404753d70 t;
t.ssENProposalApprovalLevel = (EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord)this.ssENProposalApprovalLevel.Duplicate();
t.ssENProposalLineApprovalLevel = (EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord)this.ssENProposalLineApprovalLevel.Duplicate();
t.ssENProposalLine = (EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord)this.ssENProposalLine.Duplicate();
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
} else if (head == "proposalline") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalLine")) variable.Value = ssENProposalLine; else variable.Optimized = true;
variable.SetFieldName("proposalline");
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
if (key == IdProposalLine) {
return ssENProposalLine;
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
if (attributeKey == IdProposalLine.Key.AsGuid) {
return ssENProposalLine;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENProposalApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdProposalApprovalLevel));
ssENProposalLineApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdProposalLineApprovalLevel));
ssENProposalLine.FillFromOther((IRecord) other.AttributeGet(IdProposalLine));
}
} // RC_90af34fed2114347870a398404753d70
/// <summary>
/// RecordList type <code>ProposalApprovalLevelProposalLineApprovalLevelProposalLineRecordList</code>
///  that represents a record list of <code>ProposalApprovalLevel, ProposalLineApprovalLevel
/// , ProposalLine</code>
/// </summary>
public partial class RL_379ef1eaf8ca0c4557841a9701c37878 : GenericRecordList<RC_90af34fed2114347870a398404753d70>, IEnumerable, IEnumerator {

protected override RC_90af34fed2114347870a398404753d70 GetElementDefaultValue() {
return new RC_90af34fed2114347870a398404753d70();
}

public T[] ToArray<T>(Func<RC_90af34fed2114347870a398404753d70, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_379ef1eaf8ca0c4557841a9701c37878 recordList, Func<RC_90af34fed2114347870a398404753d70, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_379ef1eaf8ca0c4557841a9701c37878(RC_90af34fed2114347870a398404753d70[] array) {
  RL_379ef1eaf8ca0c4557841a9701c37878 result = new RL_379ef1eaf8ca0c4557841a9701c37878();
result.InnerFromArray(array);
    return result;
}

public static RL_379ef1eaf8ca0c4557841a9701c37878 ToList<T>(T[] array, Func <T, RC_90af34fed2114347870a398404753d70> converter) {
  RL_379ef1eaf8ca0c4557841a9701c37878 result = new RL_379ef1eaf8ca0c4557841a9701c37878();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_379ef1eaf8ca0c4557841a9701c37878 FromRestList<T>(RestList<T> restList, Func <T, RC_90af34fed2114347870a398404753d70> converter) {
  RL_379ef1eaf8ca0c4557841a9701c37878 result = new RL_379ef1eaf8ca0c4557841a9701c37878();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_379ef1eaf8ca0c4557841a9701c37878() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(7,false);
def[1] = new BitArray(9,false);
def[2] = new BitArray(28,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_90af34fed2114347870a398404753d70> NewList() {
return new RL_379ef1eaf8ca0c4557841a9701c37878();
}


} // RL_379ef1eaf8ca0c4557841a9701c37878
}

