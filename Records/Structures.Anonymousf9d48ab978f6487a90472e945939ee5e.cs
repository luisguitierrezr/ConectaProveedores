namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (uYrU+fZ4ekiQRy6UWTnuXg)
///  <code>RC_875fb45d4123a91fce83831f0f554d8e</code> that represent
/// s <code>ProposalLineApprovalLevelRecord</code> <p>Description: </p>
/// </summary>
// Name: ProposalLineApprovalLevelRecord
public partial struct RC_875fb45d4123a91fce83831f0f554d8e : ITypedRecord<RC_875fb45d4123a91fce83831f0f554d8e> {
internal static readonly GlobalObjectKey IdProposalLineApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*XbRfhyNBH6nOg4MfD1VNjg");

public EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord ssENProposalLineApprovalLevel;


public static implicit operator EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord( RC_875fb45d4123a91fce83831f0f554d8e r) {
return r.ssENProposalLineApprovalLevel;
}

public static implicit operator RC_875fb45d4123a91fce83831f0f554d8e (EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord r) {
RC_875fb45d4123a91fce83831f0f554d8e res = new RC_875fb45d4123a91fce83831f0f554d8e ();
res.ssENProposalLineApprovalLevel = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENProposalLineApprovalLevel.ChangedAttributes = value;
}
get {
    return ssENProposalLineApprovalLevel.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_875fb45d4123a91fce83831f0f554d8e() {
OptimizedAttributes = null;
ssENProposalLineApprovalLevel = new EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(9,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENProposalLineApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENProposalLineApprovalLevel.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENProposalLineApprovalLevel.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
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
public void ReadIM(RC_875fb45d4123a91fce83831f0f554d8e r) {
this = r;
}


public static bool operator == (RC_875fb45d4123a91fce83831f0f554d8e a, RC_875fb45d4123a91fce83831f0f554d8e b) {
if (a.ssENProposalLineApprovalLevel != b.ssENProposalLineApprovalLevel) return false;
return true;
}

public static bool operator != (RC_875fb45d4123a91fce83831f0f554d8e a, RC_875fb45d4123a91fce83831f0f554d8e b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_875fb45d4123a91fce83831f0f554d8e)) return false;
return (this == (RC_875fb45d4123a91fce83831f0f554d8e)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENProposalLineApprovalLevel.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENProposalLineApprovalLevel.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENProposalLineApprovalLevel.InternalRecursiveSave();
}


public RC_875fb45d4123a91fce83831f0f554d8e Duplicate() {
RC_875fb45d4123a91fce83831f0f554d8e t;
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
if (head == "proposallineapprovallevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalLineApprovalLevel")) variable.Value = ssENProposalLineApprovalLevel; else variable.Optimized = true;
variable.SetFieldName("proposallineapprovallevel");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENProposalLineApprovalLevel.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENProposalLineApprovalLevel.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdProposalLineApprovalLevel) {
return ssENProposalLineApprovalLevel;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdProposalLineApprovalLevel.Key.AsGuid) {
return ssENProposalLineApprovalLevel;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENProposalLineApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdProposalLineApprovalLevel));
}
} // RC_875fb45d4123a91fce83831f0f554d8e
/// <summary>
/// RecordList type <code>ProposalLineApprovalLevelRecordList</code> that represents a record list of
///  <code>ProposalLineApprovalLevel</code>
/// </summary>
public partial class RL_cb657a85ad5767a90a0cf2a0623ecec3 : GenericRecordList<RC_875fb45d4123a91fce83831f0f554d8e>, IEnumerable, IEnumerator {

protected override RC_875fb45d4123a91fce83831f0f554d8e GetElementDefaultValue() {
return new RC_875fb45d4123a91fce83831f0f554d8e();
}

public T[] ToArray<T>(Func<RC_875fb45d4123a91fce83831f0f554d8e, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_cb657a85ad5767a90a0cf2a0623ecec3 recordList, Func<RC_875fb45d4123a91fce83831f0f554d8e, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_cb657a85ad5767a90a0cf2a0623ecec3(RC_875fb45d4123a91fce83831f0f554d8e[] array) {
  RL_cb657a85ad5767a90a0cf2a0623ecec3 result = new RL_cb657a85ad5767a90a0cf2a0623ecec3();
result.InnerFromArray(array);
    return result;
}

public static RL_cb657a85ad5767a90a0cf2a0623ecec3 ToList<T>(T[] array, Func <T, RC_875fb45d4123a91fce83831f0f554d8e> converter) {
  RL_cb657a85ad5767a90a0cf2a0623ecec3 result = new RL_cb657a85ad5767a90a0cf2a0623ecec3();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_cb657a85ad5767a90a0cf2a0623ecec3 FromRestList<T>(RestList<T> restList, Func <T, RC_875fb45d4123a91fce83831f0f554d8e> converter) {
  RL_cb657a85ad5767a90a0cf2a0623ecec3 result = new RL_cb657a85ad5767a90a0cf2a0623ecec3();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_cb657a85ad5767a90a0cf2a0623ecec3() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(9,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_875fb45d4123a91fce83831f0f554d8e> NewList() {
return new RL_cb657a85ad5767a90a0cf2a0623ecec3();
}


} // RL_cb657a85ad5767a90a0cf2a0623ecec3
}

