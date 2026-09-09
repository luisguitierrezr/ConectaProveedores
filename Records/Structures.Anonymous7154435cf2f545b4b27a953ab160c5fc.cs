namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (XENUcfXytEWyepU6sWDF_A)
///  <code>RC_b58bb1464cbfe8396a13ee4355d45880</code> that represents <code>OrdersRequestRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: OrdersRequestRecord
public partial struct RC_b58bb1464cbfe8396a13ee4355d45880 : ITypedRecord<RC_b58bb1464cbfe8396a13ee4355d45880> {
internal static readonly GlobalObjectKey IdOrdersRequest = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*RrGLtb9MOehqE+5DVdRYgA");

public ST_9c87dd52bd762501ef8a064794927f08Structure ssSTOrdersRequest;


public static implicit operator ST_9c87dd52bd762501ef8a064794927f08Structure( RC_b58bb1464cbfe8396a13ee4355d45880 r) {
return r.ssSTOrdersRequest;
}

public static implicit operator RC_b58bb1464cbfe8396a13ee4355d45880 (ST_9c87dd52bd762501ef8a064794927f08Structure r) {
RC_b58bb1464cbfe8396a13ee4355d45880 res = new RC_b58bb1464cbfe8396a13ee4355d45880 ();
res.ssSTOrdersRequest = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_b58bb1464cbfe8396a13ee4355d45880() {
OptimizedAttributes = null;
ssSTOrdersRequest = new ST_9c87dd52bd762501ef8a064794927f08Structure();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssSTOrdersRequest.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssSTOrdersRequest.Read( r, ref index);
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
public void ReadIM(RC_b58bb1464cbfe8396a13ee4355d45880 r) {
this = r;
}


public static bool operator == (RC_b58bb1464cbfe8396a13ee4355d45880 a, RC_b58bb1464cbfe8396a13ee4355d45880 b) {
if (a.ssSTOrdersRequest != b.ssSTOrdersRequest) return false;
return true;
}

public static bool operator != (RC_b58bb1464cbfe8396a13ee4355d45880 a, RC_b58bb1464cbfe8396a13ee4355d45880 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_b58bb1464cbfe8396a13ee4355d45880)) return false;
return (this == (RC_b58bb1464cbfe8396a13ee4355d45880)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTOrdersRequest.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTOrdersRequest.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTOrdersRequest.InternalRecursiveSave();
}


public RC_b58bb1464cbfe8396a13ee4355d45880 Duplicate() {
RC_b58bb1464cbfe8396a13ee4355d45880 t;
t.ssSTOrdersRequest = (ST_9c87dd52bd762501ef8a064794927f08Structure)this.ssSTOrdersRequest.Duplicate();
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
if (head == "ordersrequest") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrdersRequest")) variable.Value = ssSTOrdersRequest; else variable.Optimized = true;
variable.SetFieldName("ordersrequest");
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
if (key == IdOrdersRequest) {
return ssSTOrdersRequest;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrdersRequest.Key.AsGuid) {
return ssSTOrdersRequest;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTOrdersRequest.FillFromOther((IRecord) other.AttributeGet(IdOrdersRequest));
}
} // RC_b58bb1464cbfe8396a13ee4355d45880
/// <summary>
/// RecordList type <code>OrdersRequestRecordList</code> that represents a record list of
///  <code>OrdersRequest</code>
/// </summary>
public partial class RL_180ad5cd15c4085c882c9f8040eae03c : GenericRecordList<RC_b58bb1464cbfe8396a13ee4355d45880>, IEnumerable, IEnumerator {

protected override RC_b58bb1464cbfe8396a13ee4355d45880 GetElementDefaultValue() {
return new RC_b58bb1464cbfe8396a13ee4355d45880();
}

public T[] ToArray<T>(Func<RC_b58bb1464cbfe8396a13ee4355d45880, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_180ad5cd15c4085c882c9f8040eae03c recordList, Func<RC_b58bb1464cbfe8396a13ee4355d45880, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_180ad5cd15c4085c882c9f8040eae03c(RC_b58bb1464cbfe8396a13ee4355d45880[] array) {
  RL_180ad5cd15c4085c882c9f8040eae03c result = new RL_180ad5cd15c4085c882c9f8040eae03c();
result.InnerFromArray(array);
    return result;
}

public static RL_180ad5cd15c4085c882c9f8040eae03c ToList<T>(T[] array, Func <T, RC_b58bb1464cbfe8396a13ee4355d45880> converter) {
  RL_180ad5cd15c4085c882c9f8040eae03c result = new RL_180ad5cd15c4085c882c9f8040eae03c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_180ad5cd15c4085c882c9f8040eae03c FromRestList<T>(RestList<T> restList, Func <T, RC_b58bb1464cbfe8396a13ee4355d45880> converter) {
  RL_180ad5cd15c4085c882c9f8040eae03c result = new RL_180ad5cd15c4085c882c9f8040eae03c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_180ad5cd15c4085c882c9f8040eae03c() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_b58bb1464cbfe8396a13ee4355d45880> NewList() {
return new RL_180ad5cd15c4085c882c9f8040eae03c();
}


} // RL_180ad5cd15c4085c882c9f8040eae03c
}

