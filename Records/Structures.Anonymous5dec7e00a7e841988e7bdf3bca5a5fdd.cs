namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (AH7sXeinmEGOe987ylpf3Q)
///  <code>RC_344c35cf0b565533cad543b081be7d24</code> that represent
/// s <code>ProposalProposalCommentProposalLineSupplierRegionRecord</code> <p>Description: </p>
/// </summary>
// Name: ProposalProposalCommentProposalLineSupplierRegionRecord
public partial struct RC_344c35cf0b565533cad543b081be7d24 : ITypedRecord<RC_344c35cf0b565533cad543b081be7d24> {
internal static readonly GlobalObjectKey IdProposal = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*9MStkYpvUQ_KzEvHGNLqNQ");
internal static readonly GlobalObjectKey IdProposalComment = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*zQFRzf8x3NgJrsrKbXcASg");
internal static readonly GlobalObjectKey IdProposalLine = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Ejn_ywl2+KAwstNJSNHAGQ");
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dOw0SWrcY4B7hMCYX1sSzg");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w1243kBmkvqNrl3ySTBl0A");

public EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord ssENProposal;

public EN_c75b4bd59e1200fee3175175a6054340EntityRecord ssENProposalComment;

public EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord ssENProposalLine;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion;


public BitArray OptimizedAttributes;

public RC_344c35cf0b565533cad543b081be7d24() {
OptimizedAttributes = null;
ssENProposal = new EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord();
ssENProposalComment = new EN_c75b4bd59e1200fee3175175a6054340EntityRecord();
ssENProposalLine = new EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord();
ssENSupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
ssENRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[5];
    all[0] = new BitArray(18,false);
    all[1] = new BitArray(8,false);
    all[2] = new BitArray(28,false);
    all[3] = new BitArray(28,false);
    all[4] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENProposal.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENProposalComment.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENProposalLine.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENSupplier.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENRegion.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    }else{
    ssENProposal.OptimizedAttributes = value[0];
    ssENProposalComment.OptimizedAttributes = value[1];
    ssENProposalLine.OptimizedAttributes = value[2];
    ssENSupplier.OptimizedAttributes = value[3];
    ssENRegion.OptimizedAttributes = value[4];
    }
}
get{
    BitArray[] all = new BitArray[5];
    all[0] = ssENProposal.OptimizedAttributes;
    all[1] = ssENProposalComment.OptimizedAttributes;
    all[2] = ssENProposalLine.OptimizedAttributes;
    all[3] = ssENSupplier.OptimizedAttributes;
    all[4] = ssENRegion.OptimizedAttributes;
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
ssENProposalComment.Read( r, ref index);
ssENProposalLine.Read( r, ref index);
ssENSupplier.Read( r, ref index);
ssENRegion.Read( r, ref index);
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
public void ReadIM(RC_344c35cf0b565533cad543b081be7d24 r) {
this = r;
}


public static bool operator == (RC_344c35cf0b565533cad543b081be7d24 a, RC_344c35cf0b565533cad543b081be7d24 b) {
if (a.ssENProposal != b.ssENProposal) return false;
if (a.ssENProposalComment != b.ssENProposalComment) return false;
if (a.ssENProposalLine != b.ssENProposalLine) return false;
if (a.ssENSupplier != b.ssENSupplier) return false;
if (a.ssENRegion != b.ssENRegion) return false;
return true;
}

public static bool operator != (RC_344c35cf0b565533cad543b081be7d24 a, RC_344c35cf0b565533cad543b081be7d24 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_344c35cf0b565533cad543b081be7d24)) return false;
return (this == (RC_344c35cf0b565533cad543b081be7d24)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENProposal.GetHashCode()
 ^ ssENProposalComment.GetHashCode()
 ^ ssENProposalLine.GetHashCode()
 ^ ssENSupplier.GetHashCode()
 ^ ssENRegion.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENProposal.RecursiveReset();
ssENProposalComment.RecursiveReset();
ssENProposalLine.RecursiveReset();
ssENSupplier.RecursiveReset();
ssENRegion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENProposal.InternalRecursiveSave();
ssENProposalComment.InternalRecursiveSave();
ssENProposalLine.InternalRecursiveSave();
ssENSupplier.InternalRecursiveSave();
ssENRegion.InternalRecursiveSave();
}


public RC_344c35cf0b565533cad543b081be7d24 Duplicate() {
RC_344c35cf0b565533cad543b081be7d24 t;
t.ssENProposal = (EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord)this.ssENProposal.Duplicate();
t.ssENProposalComment = (EN_c75b4bd59e1200fee3175175a6054340EntityRecord)this.ssENProposalComment.Duplicate();
t.ssENProposalLine = (EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord)this.ssENProposalLine.Duplicate();
t.ssENSupplier = (EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord)this.ssENSupplier.Duplicate();
t.ssENRegion = (EN_31f501c551d210017fcb34b5237e3390EntityRecord)this.ssENRegion.Duplicate();
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
} else if (head == "proposalcomment") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalComment")) variable.Value = ssENProposalComment; else variable.Optimized = true;
variable.SetFieldName("proposalcomment");
} else if (head == "proposalline") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalLine")) variable.Value = ssENProposalLine; else variable.Optimized = true;
variable.SetFieldName("proposalline");
} else if (head == "supplier") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Supplier")) variable.Value = ssENSupplier; else variable.Optimized = true;
variable.SetFieldName("supplier");
} else if (head == "region") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Region")) variable.Value = ssENRegion; else variable.Optimized = true;
variable.SetFieldName("region");
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
if (key == IdProposalComment) {
return ssENProposalComment;
}
if (key == IdProposalLine) {
return ssENProposalLine;
}
if (key == IdSupplier) {
return ssENSupplier;
}
if (key == IdRegion) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdProposal.Key.AsGuid) {
return ssENProposal;
}
if (attributeKey == IdProposalComment.Key.AsGuid) {
return ssENProposalComment;
}
if (attributeKey == IdProposalLine.Key.AsGuid) {
return ssENProposalLine;
}
if (attributeKey == IdSupplier.Key.AsGuid) {
return ssENSupplier;
}
if (attributeKey == IdRegion.Key.AsGuid) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENProposal.FillFromOther((IRecord) other.AttributeGet(IdProposal));
ssENProposalComment.FillFromOther((IRecord) other.AttributeGet(IdProposalComment));
ssENProposalLine.FillFromOther((IRecord) other.AttributeGet(IdProposalLine));
ssENSupplier.FillFromOther((IRecord) other.AttributeGet(IdSupplier));
ssENRegion.FillFromOther((IRecord) other.AttributeGet(IdRegion));
}
} // RC_344c35cf0b565533cad543b081be7d24
/// <summary>
/// RecordList type <code>ProposalProposalCommentProposalLineSupplierRegionRecordList</code> that
///  represents a record list of <code>Proposal, ProposalComment, ProposalLine, Supplier, Region</code>
/// </summary>
public partial class RL_273266e5ba4c20bd7cdd113c40b539f2 : GenericRecordList<RC_344c35cf0b565533cad543b081be7d24>, IEnumerable, IEnumerator {

protected override RC_344c35cf0b565533cad543b081be7d24 GetElementDefaultValue() {
return new RC_344c35cf0b565533cad543b081be7d24();
}

public T[] ToArray<T>(Func<RC_344c35cf0b565533cad543b081be7d24, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_273266e5ba4c20bd7cdd113c40b539f2 recordList, Func<RC_344c35cf0b565533cad543b081be7d24, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_273266e5ba4c20bd7cdd113c40b539f2(RC_344c35cf0b565533cad543b081be7d24[] array) {
  RL_273266e5ba4c20bd7cdd113c40b539f2 result = new RL_273266e5ba4c20bd7cdd113c40b539f2();
result.InnerFromArray(array);
    return result;
}

public static RL_273266e5ba4c20bd7cdd113c40b539f2 ToList<T>(T[] array, Func <T, RC_344c35cf0b565533cad543b081be7d24> converter) {
  RL_273266e5ba4c20bd7cdd113c40b539f2 result = new RL_273266e5ba4c20bd7cdd113c40b539f2();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_273266e5ba4c20bd7cdd113c40b539f2 FromRestList<T>(RestList<T> restList, Func <T, RC_344c35cf0b565533cad543b081be7d24> converter) {
  RL_273266e5ba4c20bd7cdd113c40b539f2 result = new RL_273266e5ba4c20bd7cdd113c40b539f2();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_273266e5ba4c20bd7cdd113c40b539f2() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[5];
def[0] = new BitArray(18,false);
def[1] = new BitArray(8,false);
def[2] = new BitArray(28,false);
def[3] = new BitArray(28,false);
def[4] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_344c35cf0b565533cad543b081be7d24> NewList() {
return new RL_273266e5ba4c20bd7cdd113c40b539f2();
}


} // RL_273266e5ba4c20bd7cdd113c40b539f2
}

