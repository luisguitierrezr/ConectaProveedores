namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (T7gZTE8v0Uu0YGDJtnD6xQ)
///  <code>RC_577e0d18883096d0ebc3eb78e20586ee</code> that represent
/// s <code>ProposalProposalApprovalRecord</code> <p>Description: </p>
/// </summary>
// Name: ProposalProposalApprovalRecord
public partial struct RC_577e0d18883096d0ebc3eb78e20586ee : ITypedRecord<RC_577e0d18883096d0ebc3eb78e20586ee> {
internal static readonly GlobalObjectKey IdProposal = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*9MStkYpvUQ_KzEvHGNLqNQ");
internal static readonly GlobalObjectKey IdProposalApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*1sFbHhDQH3aGXjoHdPHIGQ");

public EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord ssENProposal;

public EN_5464a383ceb6bec564e8dfa03f011357EntityRecord ssENProposalApproval;


public BitArray OptimizedAttributes;

public RC_577e0d18883096d0ebc3eb78e20586ee() {
OptimizedAttributes = null;
ssENProposal = new EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord();
ssENProposalApproval = new EN_5464a383ceb6bec564e8dfa03f011357EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(18,false);
    all[1] = new BitArray(8,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENProposal.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENProposalApproval.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENProposal.OptimizedAttributes = value[0];
    ssENProposalApproval.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENProposal.OptimizedAttributes;
    all[1] = ssENProposalApproval.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENProposal.Read( r, ref index);
ssENProposalApproval.Read( r, ref index);
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
public void ReadIM(RC_577e0d18883096d0ebc3eb78e20586ee r) {
this = r;
}


public static bool operator == (RC_577e0d18883096d0ebc3eb78e20586ee a, RC_577e0d18883096d0ebc3eb78e20586ee b) {
if (a.ssENProposal != b.ssENProposal) return false;
if (a.ssENProposalApproval != b.ssENProposalApproval) return false;
return true;
}

public static bool operator != (RC_577e0d18883096d0ebc3eb78e20586ee a, RC_577e0d18883096d0ebc3eb78e20586ee b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_577e0d18883096d0ebc3eb78e20586ee)) return false;
return (this == (RC_577e0d18883096d0ebc3eb78e20586ee)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENProposal.GetHashCode()
 ^ ssENProposalApproval.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENProposal.RecursiveReset();
ssENProposalApproval.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENProposal.InternalRecursiveSave();
ssENProposalApproval.InternalRecursiveSave();
}


public RC_577e0d18883096d0ebc3eb78e20586ee Duplicate() {
RC_577e0d18883096d0ebc3eb78e20586ee t;
t.ssENProposal = (EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord)this.ssENProposal.Duplicate();
t.ssENProposalApproval = (EN_5464a383ceb6bec564e8dfa03f011357EntityRecord)this.ssENProposalApproval.Duplicate();
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
if (head == "proposal") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Proposal")) variable.Value = ssENProposal; else variable.Optimized = true;
variable.SetFieldName("proposal");
} else if (head == "proposalapproval") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalApproval")) variable.Value = ssENProposalApproval; else variable.Optimized = true;
variable.SetFieldName("proposalapproval");
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
if (key == IdProposal) {
return ssENProposal;
}
if (key == IdProposalApproval) {
return ssENProposalApproval;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdProposal.Key.AsGuid) {
return ssENProposal;
}
if (attributeKey == IdProposalApproval.Key.AsGuid) {
return ssENProposalApproval;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENProposal.FillFromOther((IRecord) other.AttributeGet(IdProposal));
ssENProposalApproval.FillFromOther((IRecord) other.AttributeGet(IdProposalApproval));
}
} // RC_577e0d18883096d0ebc3eb78e20586ee
/// <summary>
/// RecordList type <code>ProposalProposalApprovalRecordList</code> that represents a record list of
///  <code>Proposal, ProposalApproval</code>
/// </summary>
public partial class RL_539231a5cc05839b9d01250c4ae7131c : GenericRecordList<RC_577e0d18883096d0ebc3eb78e20586ee>, IEnumerable, IEnumerator {

protected override RC_577e0d18883096d0ebc3eb78e20586ee GetElementDefaultValue() {
return new RC_577e0d18883096d0ebc3eb78e20586ee();
}

public T[] ToArray<T>(Func<RC_577e0d18883096d0ebc3eb78e20586ee, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_539231a5cc05839b9d01250c4ae7131c recordList, Func<RC_577e0d18883096d0ebc3eb78e20586ee, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_539231a5cc05839b9d01250c4ae7131c(RC_577e0d18883096d0ebc3eb78e20586ee[] array) {
  RL_539231a5cc05839b9d01250c4ae7131c result = new RL_539231a5cc05839b9d01250c4ae7131c();
result.InnerFromArray(array);
    return result;
}

public static RL_539231a5cc05839b9d01250c4ae7131c ToList<T>(T[] array, Func <T, RC_577e0d18883096d0ebc3eb78e20586ee> converter) {
  RL_539231a5cc05839b9d01250c4ae7131c result = new RL_539231a5cc05839b9d01250c4ae7131c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_539231a5cc05839b9d01250c4ae7131c FromRestList<T>(RestList<T> restList, Func <T, RC_577e0d18883096d0ebc3eb78e20586ee> converter) {
  RL_539231a5cc05839b9d01250c4ae7131c result = new RL_539231a5cc05839b9d01250c4ae7131c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_539231a5cc05839b9d01250c4ae7131c() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(18,false);
def[1] = new BitArray(8,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_577e0d18883096d0ebc3eb78e20586ee> NewList() {
return new RL_539231a5cc05839b9d01250c4ae7131c();
}


} // RL_539231a5cc05839b9d01250c4ae7131c
}

