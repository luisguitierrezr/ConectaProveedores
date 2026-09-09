namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (esCPJnfQr0uSfogmtreKtQ)
///  <code>RC_829c5fdbd08f778c26d3a6457b4b0808</code> that represent
/// s <code>OrderApprovalLevelIdOrderIdRecord</code> <p>Description: </p>
/// </summary>
// Name: OrderApprovalLevelIdOrderIdRecord
public partial struct RC_829c5fdbd08f778c26d3a6457b4b0808 : ITypedRecord<RC_829c5fdbd08f778c26d3a6457b4b0808> {
internal static readonly GlobalObjectKey IdOrderApprovalLevelId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+ouV7HzXTYE2oWuT8FMIHw");
internal static readonly GlobalObjectKey IdOrderId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*MyrPE+4JDyQyUSOcXegF4w");

public long ssOrderApprovalLevelId;

public long ssOrderId;


public BitArray OptimizedAttributes;

public RC_829c5fdbd08f778c26d3a6457b4b0808() {
OptimizedAttributes = null;
ssOrderApprovalLevelId = 0L;
ssOrderId = 0L;
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
ssOrderApprovalLevelId = r.ReadEntityReferenceLongInteger(index++, "OrderApprovalLevelIdOrderIdRecord.OrderApprovalLevelId", 0L);
ssOrderId = r.ReadEntityReferenceLongInteger(index++, "OrderApprovalLevelIdOrderIdRecord.OrderId", 0L);
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
public void ReadIM(RC_829c5fdbd08f778c26d3a6457b4b0808 r) {
this = r;
}


public static bool operator == (RC_829c5fdbd08f778c26d3a6457b4b0808 a, RC_829c5fdbd08f778c26d3a6457b4b0808 b) {
if (a.ssOrderApprovalLevelId != b.ssOrderApprovalLevelId) return false;
if (a.ssOrderId != b.ssOrderId) return false;
return true;
}

public static bool operator != (RC_829c5fdbd08f778c26d3a6457b4b0808 a, RC_829c5fdbd08f778c26d3a6457b4b0808 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_829c5fdbd08f778c26d3a6457b4b0808)) return false;
return (this == (RC_829c5fdbd08f778c26d3a6457b4b0808)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssOrderApprovalLevelId.GetHashCode()
 ^ ssOrderId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_829c5fdbd08f778c26d3a6457b4b0808 Duplicate() {
RC_829c5fdbd08f778c26d3a6457b4b0808 t;
t.ssOrderApprovalLevelId = this.ssOrderApprovalLevelId;
t.ssOrderId = this.ssOrderId;
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
if (head == "orderapprovallevelid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderApprovalLevelId")) variable.Value = ssOrderApprovalLevelId; else variable.Optimized = true;
} else if (head == "orderid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderId")) variable.Value = ssOrderId; else variable.Optimized = true;
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
if (key == IdOrderApprovalLevelId) {
return ssOrderApprovalLevelId;
}
if (key == IdOrderId) {
return ssOrderId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderApprovalLevelId.Key.AsGuid) {
return ssOrderApprovalLevelId;
}
if (attributeKey == IdOrderId.Key.AsGuid) {
return ssOrderId;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssOrderApprovalLevelId = (long) other.AttributeGet(IdOrderApprovalLevelId);
ssOrderId = (long) other.AttributeGet(IdOrderId);
}
} // RC_829c5fdbd08f778c26d3a6457b4b0808
/// <summary>
/// RecordList type <code>OrderApprovalLevelIdOrderIdRecordList</code> that represents a record list of
///  <code>OrderApprovalLevelIdentifier, OrderMainIdentifier</code>
/// </summary>
public partial class RL_35197d78da55a316e453192f6bb43d39 : GenericRecordList<RC_829c5fdbd08f778c26d3a6457b4b0808>, IEnumerable, IEnumerator {

protected override RC_829c5fdbd08f778c26d3a6457b4b0808 GetElementDefaultValue() {
return new RC_829c5fdbd08f778c26d3a6457b4b0808();
}

public T[] ToArray<T>(Func<RC_829c5fdbd08f778c26d3a6457b4b0808, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_35197d78da55a316e453192f6bb43d39 recordList, Func<RC_829c5fdbd08f778c26d3a6457b4b0808, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_35197d78da55a316e453192f6bb43d39(RC_829c5fdbd08f778c26d3a6457b4b0808[] array) {
  RL_35197d78da55a316e453192f6bb43d39 result = new RL_35197d78da55a316e453192f6bb43d39();
result.InnerFromArray(array);
    return result;
}

public static RL_35197d78da55a316e453192f6bb43d39 ToList<T>(T[] array, Func <T, RC_829c5fdbd08f778c26d3a6457b4b0808> converter) {
  RL_35197d78da55a316e453192f6bb43d39 result = new RL_35197d78da55a316e453192f6bb43d39();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_35197d78da55a316e453192f6bb43d39 FromRestList<T>(RestList<T> restList, Func <T, RC_829c5fdbd08f778c26d3a6457b4b0808> converter) {
  RL_35197d78da55a316e453192f6bb43d39 result = new RL_35197d78da55a316e453192f6bb43d39();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_35197d78da55a316e453192f6bb43d39() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_829c5fdbd08f778c26d3a6457b4b0808> NewList() {
return new RL_35197d78da55a316e453192f6bb43d39();
}


} // RL_35197d78da55a316e453192f6bb43d39
}

