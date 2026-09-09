namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (KezqItKb3Uasq628PEUU2w)
///  <code>RC_2a29aed0a2b753b8e46cbcb586392c66</code> that represent
/// s <code>ProposalFileExtendedRecord</code> <p>Description: </p>
/// </summary>
// Name: ProposalFileExtendedRecord
public partial struct RC_2a29aed0a2b753b8e46cbcb586392c66 : ITypedRecord<RC_2a29aed0a2b753b8e46cbcb586392c66> {
internal static readonly GlobalObjectKey IdProposal = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*9MStkYpvUQ_KzEvHGNLqNQ");
internal static readonly GlobalObjectKey IdFileExtended = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*jaI+blUswivMEp9CKX5Zgg");

public EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord ssENProposal;

public EN_dcebdd8ba305133f41b1e1804925997fEntityRecord ssENFileExtended;


public BitArray OptimizedAttributes;

public RC_2a29aed0a2b753b8e46cbcb586392c66() {
OptimizedAttributes = null;
ssENProposal = new EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord();
ssENFileExtended = new EN_dcebdd8ba305133f41b1e1804925997fEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(18,false);
    all[1] = new BitArray(7,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENProposal.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENFileExtended.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENProposal.OptimizedAttributes = value[0];
    ssENFileExtended.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENProposal.OptimizedAttributes;
    all[1] = ssENFileExtended.OptimizedAttributes;
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
ssENFileExtended.Read( r, ref index);
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
public void ReadIM(RC_2a29aed0a2b753b8e46cbcb586392c66 r) {
this = r;
}


public static bool operator == (RC_2a29aed0a2b753b8e46cbcb586392c66 a, RC_2a29aed0a2b753b8e46cbcb586392c66 b) {
if (a.ssENProposal != b.ssENProposal) return false;
if (a.ssENFileExtended != b.ssENFileExtended) return false;
return true;
}

public static bool operator != (RC_2a29aed0a2b753b8e46cbcb586392c66 a, RC_2a29aed0a2b753b8e46cbcb586392c66 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_2a29aed0a2b753b8e46cbcb586392c66)) return false;
return (this == (RC_2a29aed0a2b753b8e46cbcb586392c66)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENProposal.GetHashCode()
 ^ ssENFileExtended.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENProposal.RecursiveReset();
ssENFileExtended.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENProposal.InternalRecursiveSave();
ssENFileExtended.InternalRecursiveSave();
}


public RC_2a29aed0a2b753b8e46cbcb586392c66 Duplicate() {
RC_2a29aed0a2b753b8e46cbcb586392c66 t;
t.ssENProposal = (EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord)this.ssENProposal.Duplicate();
t.ssENFileExtended = (EN_dcebdd8ba305133f41b1e1804925997fEntityRecord)this.ssENFileExtended.Duplicate();
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
} else if (head == "fileextended") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FileExtended")) variable.Value = ssENFileExtended; else variable.Optimized = true;
variable.SetFieldName("fileextended");
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
if (key == IdFileExtended) {
return ssENFileExtended;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdProposal.Key.AsGuid) {
return ssENProposal;
}
if (attributeKey == IdFileExtended.Key.AsGuid) {
return ssENFileExtended;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENProposal.FillFromOther((IRecord) other.AttributeGet(IdProposal));
ssENFileExtended.FillFromOther((IRecord) other.AttributeGet(IdFileExtended));
}
} // RC_2a29aed0a2b753b8e46cbcb586392c66
/// <summary>
/// RecordList type <code>ProposalFileExtendedRecordList</code> that represents a record list of
///  <code>Proposal, FileExtended</code>
/// </summary>
public partial class RL_c7f89ca4df2a001749d1cb52057abd7c : GenericRecordList<RC_2a29aed0a2b753b8e46cbcb586392c66>, IEnumerable, IEnumerator {

protected override RC_2a29aed0a2b753b8e46cbcb586392c66 GetElementDefaultValue() {
return new RC_2a29aed0a2b753b8e46cbcb586392c66();
}

public T[] ToArray<T>(Func<RC_2a29aed0a2b753b8e46cbcb586392c66, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c7f89ca4df2a001749d1cb52057abd7c recordList, Func<RC_2a29aed0a2b753b8e46cbcb586392c66, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c7f89ca4df2a001749d1cb52057abd7c(RC_2a29aed0a2b753b8e46cbcb586392c66[] array) {
  RL_c7f89ca4df2a001749d1cb52057abd7c result = new RL_c7f89ca4df2a001749d1cb52057abd7c();
result.InnerFromArray(array);
    return result;
}

public static RL_c7f89ca4df2a001749d1cb52057abd7c ToList<T>(T[] array, Func <T, RC_2a29aed0a2b753b8e46cbcb586392c66> converter) {
  RL_c7f89ca4df2a001749d1cb52057abd7c result = new RL_c7f89ca4df2a001749d1cb52057abd7c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c7f89ca4df2a001749d1cb52057abd7c FromRestList<T>(RestList<T> restList, Func <T, RC_2a29aed0a2b753b8e46cbcb586392c66> converter) {
  RL_c7f89ca4df2a001749d1cb52057abd7c result = new RL_c7f89ca4df2a001749d1cb52057abd7c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c7f89ca4df2a001749d1cb52057abd7c() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(18,false);
def[1] = new BitArray(7,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_2a29aed0a2b753b8e46cbcb586392c66> NewList() {
return new RL_c7f89ca4df2a001749d1cb52057abd7c();
}


} // RL_c7f89ca4df2a001749d1cb52057abd7c
}

