namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (A9hNGFkMs0qFaOF868J_aw)
///  <code>RC_6a01c4ef1c8f90eed41c7255c682f6e0</code> that represent
/// s <code>OrderOrderApprovalLevelIdRecord</code> <p>Description: </p>
/// </summary>
// Name: OrderOrderApprovalLevelIdRecord
public partial struct RC_6a01c4ef1c8f90eed41c7255c682f6e0 : ITypedRecord<RC_6a01c4ef1c8f90eed41c7255c682f6e0> {
internal static readonly GlobalObjectKey IdOrder = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*zPS_HFZiYbq1IKzfCDiAkA");
internal static readonly GlobalObjectKey IdOrderApprovalLevelId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+ouV7HzXTYE2oWuT8FMIHw");

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrder;

public long ssOrderApprovalLevelId;


public BitArray OptimizedAttributes;

public RC_6a01c4ef1c8f90eed41c7255c682f6e0() {
OptimizedAttributes = null;
ssENOrder = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssOrderApprovalLevelId = 0L;
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(29,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrder.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENOrder.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENOrder.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENOrder.Read( r, ref index);
ssOrderApprovalLevelId = r.ReadEntityReferenceLongInteger(index++, "OrderOrderApprovalLevelIdRecord.OrderApprovalLevelId", 0L);
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
public void ReadIM(RC_6a01c4ef1c8f90eed41c7255c682f6e0 r) {
this = r;
}


public static bool operator == (RC_6a01c4ef1c8f90eed41c7255c682f6e0 a, RC_6a01c4ef1c8f90eed41c7255c682f6e0 b) {
if (a.ssENOrder != b.ssENOrder) return false;
if (a.ssOrderApprovalLevelId != b.ssOrderApprovalLevelId) return false;
return true;
}

public static bool operator != (RC_6a01c4ef1c8f90eed41c7255c682f6e0 a, RC_6a01c4ef1c8f90eed41c7255c682f6e0 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_6a01c4ef1c8f90eed41c7255c682f6e0)) return false;
return (this == (RC_6a01c4ef1c8f90eed41c7255c682f6e0)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrder.GetHashCode()
 ^ ssOrderApprovalLevelId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrder.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrder.InternalRecursiveSave();
}


public RC_6a01c4ef1c8f90eed41c7255c682f6e0 Duplicate() {
RC_6a01c4ef1c8f90eed41c7255c682f6e0 t;
t.ssENOrder = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrder.Duplicate();
t.ssOrderApprovalLevelId = this.ssOrderApprovalLevelId;
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
if (head == "order") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Order")) variable.Value = ssENOrder; else variable.Optimized = true;
variable.SetFieldName("order");
} else if (head == "orderapprovallevelid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderApprovalLevelId")) variable.Value = ssOrderApprovalLevelId; else variable.Optimized = true;
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
if (key == IdOrder) {
return ssENOrder;
}
if (key == IdOrderApprovalLevelId) {
return ssOrderApprovalLevelId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrder.Key.AsGuid) {
return ssENOrder;
}
if (attributeKey == IdOrderApprovalLevelId.Key.AsGuid) {
return ssOrderApprovalLevelId;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrder.FillFromOther((IRecord) other.AttributeGet(IdOrder));
ssOrderApprovalLevelId = (long) other.AttributeGet(IdOrderApprovalLevelId);
}
} // RC_6a01c4ef1c8f90eed41c7255c682f6e0
/// <summary>
/// RecordList type <code>OrderOrderApprovalLevelIdRecordList</code> that represents a record list of
///  <code>OrderMain, OrderApprovalLevelIdentifier</code>
/// </summary>
public partial class RL_8fd60efb0627be3c248dd395b7512757 : GenericRecordList<RC_6a01c4ef1c8f90eed41c7255c682f6e0>, IEnumerable, IEnumerator {

protected override RC_6a01c4ef1c8f90eed41c7255c682f6e0 GetElementDefaultValue() {
return new RC_6a01c4ef1c8f90eed41c7255c682f6e0();
}

public T[] ToArray<T>(Func<RC_6a01c4ef1c8f90eed41c7255c682f6e0, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_8fd60efb0627be3c248dd395b7512757 recordList, Func<RC_6a01c4ef1c8f90eed41c7255c682f6e0, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_8fd60efb0627be3c248dd395b7512757(RC_6a01c4ef1c8f90eed41c7255c682f6e0[] array) {
  RL_8fd60efb0627be3c248dd395b7512757 result = new RL_8fd60efb0627be3c248dd395b7512757();
result.InnerFromArray(array);
    return result;
}

public static RL_8fd60efb0627be3c248dd395b7512757 ToList<T>(T[] array, Func <T, RC_6a01c4ef1c8f90eed41c7255c682f6e0> converter) {
  RL_8fd60efb0627be3c248dd395b7512757 result = new RL_8fd60efb0627be3c248dd395b7512757();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_8fd60efb0627be3c248dd395b7512757 FromRestList<T>(RestList<T> restList, Func <T, RC_6a01c4ef1c8f90eed41c7255c682f6e0> converter) {
  RL_8fd60efb0627be3c248dd395b7512757 result = new RL_8fd60efb0627be3c248dd395b7512757();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_8fd60efb0627be3c248dd395b7512757() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(29,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_6a01c4ef1c8f90eed41c7255c682f6e0> NewList() {
return new RL_8fd60efb0627be3c248dd395b7512757();
}


} // RL_8fd60efb0627be3c248dd395b7512757
}

