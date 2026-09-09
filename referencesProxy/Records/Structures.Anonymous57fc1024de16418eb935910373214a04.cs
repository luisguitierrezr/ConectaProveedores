namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (JBD8VxbejkG5NZEDcyFKBA)
///  <code>RC_66db0edcff7ea9b0aa258e335add1ccc</code> that represent
/// s <code>ApprovalProcessTypeRecord</code> <p>Description: </p>
/// </summary>
// Name: ApprovalProcessTypeRecord
public partial struct RC_66db0edcff7ea9b0aa258e335add1ccc : ITypedRecord<RC_66db0edcff7ea9b0aa258e335add1ccc> {
internal static readonly GlobalObjectKey IdApprovalProcessType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*3A7bZn7_sKmqJY4zWt0czA");

public EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord ssENApprovalProcessType;


public static implicit operator EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord( RC_66db0edcff7ea9b0aa258e335add1ccc r) {
return r.ssENApprovalProcessType;
}

public static implicit operator RC_66db0edcff7ea9b0aa258e335add1ccc (EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord r) {
RC_66db0edcff7ea9b0aa258e335add1ccc res = new RC_66db0edcff7ea9b0aa258e335add1ccc ();
res.ssENApprovalProcessType = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENApprovalProcessType.ChangedAttributes = value;
}
get {
    return ssENApprovalProcessType.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_66db0edcff7ea9b0aa258e335add1ccc() {
OptimizedAttributes = null;
ssENApprovalProcessType = new EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(5,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENApprovalProcessType.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENApprovalProcessType.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENApprovalProcessType.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENApprovalProcessType.Read( r, ref index);
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
public void ReadIM(RC_66db0edcff7ea9b0aa258e335add1ccc r) {
this = r;
}


public static bool operator == (RC_66db0edcff7ea9b0aa258e335add1ccc a, RC_66db0edcff7ea9b0aa258e335add1ccc b) {
if (a.ssENApprovalProcessType != b.ssENApprovalProcessType) return false;
return true;
}

public static bool operator != (RC_66db0edcff7ea9b0aa258e335add1ccc a, RC_66db0edcff7ea9b0aa258e335add1ccc b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_66db0edcff7ea9b0aa258e335add1ccc)) return false;
return (this == (RC_66db0edcff7ea9b0aa258e335add1ccc)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENApprovalProcessType.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENApprovalProcessType.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENApprovalProcessType.InternalRecursiveSave();
}


public RC_66db0edcff7ea9b0aa258e335add1ccc Duplicate() {
RC_66db0edcff7ea9b0aa258e335add1ccc t;
t.ssENApprovalProcessType = (EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord)this.ssENApprovalProcessType.Duplicate();
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
if (head == "approvalprocesstype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApprovalProcessType")) variable.Value = ssENApprovalProcessType; else variable.Optimized = true;
variable.SetFieldName("approvalprocesstype");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENApprovalProcessType.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENApprovalProcessType.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdApprovalProcessType) {
return ssENApprovalProcessType;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdApprovalProcessType.Key.AsGuid) {
return ssENApprovalProcessType;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENApprovalProcessType.FillFromOther((IRecord) other.AttributeGet(IdApprovalProcessType));
}
} // RC_66db0edcff7ea9b0aa258e335add1ccc
/// <summary>
/// RecordList type <code>ApprovalProcessTypeRecordList</code> that represents a record list of
///  <code>ApprovalProcessType</code>
/// </summary>
public partial class RL_aa462092dd42df329d9d5474c2d56c53 : GenericRecordList<RC_66db0edcff7ea9b0aa258e335add1ccc>, IEnumerable, IEnumerator {

protected override RC_66db0edcff7ea9b0aa258e335add1ccc GetElementDefaultValue() {
return new RC_66db0edcff7ea9b0aa258e335add1ccc();
}

public T[] ToArray<T>(Func<RC_66db0edcff7ea9b0aa258e335add1ccc, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_aa462092dd42df329d9d5474c2d56c53 recordList, Func<RC_66db0edcff7ea9b0aa258e335add1ccc, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_aa462092dd42df329d9d5474c2d56c53(RC_66db0edcff7ea9b0aa258e335add1ccc[] array) {
  RL_aa462092dd42df329d9d5474c2d56c53 result = new RL_aa462092dd42df329d9d5474c2d56c53();
result.InnerFromArray(array);
    return result;
}

public static RL_aa462092dd42df329d9d5474c2d56c53 ToList<T>(T[] array, Func <T, RC_66db0edcff7ea9b0aa258e335add1ccc> converter) {
  RL_aa462092dd42df329d9d5474c2d56c53 result = new RL_aa462092dd42df329d9d5474c2d56c53();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_aa462092dd42df329d9d5474c2d56c53 FromRestList<T>(RestList<T> restList, Func <T, RC_66db0edcff7ea9b0aa258e335add1ccc> converter) {
  RL_aa462092dd42df329d9d5474c2d56c53 result = new RL_aa462092dd42df329d9d5474c2d56c53();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_aa462092dd42df329d9d5474c2d56c53() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(5,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_66db0edcff7ea9b0aa258e335add1ccc> NewList() {
return new RL_aa462092dd42df329d9d5474c2d56c53();
}


} // RL_aa462092dd42df329d9d5474c2d56c53
}

