namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (tUWCiuCT9EChNWBKjuUgiw)
///  <code>RC_64337b445a88908182ed34f64cf1399b</code> that represent
/// s <code>OrderMainOrderDetailRecord</code> <p>Description: </p>
/// </summary>
// Name: OrderMainOrderDetailRecord
public partial struct RC_64337b445a88908182ed34f64cf1399b : ITypedRecord<RC_64337b445a88908182ed34f64cf1399b> {
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");
internal static readonly GlobalObjectKey IdOrderDetail = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*__4Pf33sZAjriFX+joc3Qw");

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;

public EN_26f696e758428762fc617e811634d15dEntityRecord ssENOrderDetail;


public BitArray OptimizedAttributes;

public RC_64337b445a88908182ed34f64cf1399b() {
OptimizedAttributes = null;
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssENOrderDetail = new EN_26f696e758428762fc617e811634d15dEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(29,false);
    all[1] = new BitArray(39,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENOrderDetail.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENOrderMain.OptimizedAttributes = value[0];
    ssENOrderDetail.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENOrderMain.OptimizedAttributes;
    all[1] = ssENOrderDetail.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENOrderMain.Read( r, ref index);
ssENOrderDetail.Read( r, ref index);
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
public void ReadIM(RC_64337b445a88908182ed34f64cf1399b r) {
this = r;
}


public static bool operator == (RC_64337b445a88908182ed34f64cf1399b a, RC_64337b445a88908182ed34f64cf1399b b) {
if (a.ssENOrderMain != b.ssENOrderMain) return false;
if (a.ssENOrderDetail != b.ssENOrderDetail) return false;
return true;
}

public static bool operator != (RC_64337b445a88908182ed34f64cf1399b a, RC_64337b445a88908182ed34f64cf1399b b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_64337b445a88908182ed34f64cf1399b)) return false;
return (this == (RC_64337b445a88908182ed34f64cf1399b)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
 ^ ssENOrderDetail.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderMain.RecursiveReset();
ssENOrderDetail.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderMain.InternalRecursiveSave();
ssENOrderDetail.InternalRecursiveSave();
}


public RC_64337b445a88908182ed34f64cf1399b Duplicate() {
RC_64337b445a88908182ed34f64cf1399b t;
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
t.ssENOrderDetail = (EN_26f696e758428762fc617e811634d15dEntityRecord)this.ssENOrderDetail.Duplicate();
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
if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
} else if (head == "orderdetail") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderDetail")) variable.Value = ssENOrderDetail; else variable.Optimized = true;
variable.SetFieldName("orderdetail");
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
if (key == IdOrderMain) {
return ssENOrderMain;
}
if (key == IdOrderDetail) {
return ssENOrderDetail;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
}
if (attributeKey == IdOrderDetail.Key.AsGuid) {
return ssENOrderDetail;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
ssENOrderDetail.FillFromOther((IRecord) other.AttributeGet(IdOrderDetail));
}
} // RC_64337b445a88908182ed34f64cf1399b
/// <summary>
/// RecordList type <code>OrderMainOrderDetailRecordList</code> that represents a record list of
///  <code>OrderMain, OrderDetail</code>
/// </summary>
public partial class RL_9129a40e214c2e67892c6ae5dfbfb7b5 : GenericRecordList<RC_64337b445a88908182ed34f64cf1399b>, IEnumerable, IEnumerator {

protected override RC_64337b445a88908182ed34f64cf1399b GetElementDefaultValue() {
return new RC_64337b445a88908182ed34f64cf1399b();
}

public T[] ToArray<T>(Func<RC_64337b445a88908182ed34f64cf1399b, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_9129a40e214c2e67892c6ae5dfbfb7b5 recordList, Func<RC_64337b445a88908182ed34f64cf1399b, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_9129a40e214c2e67892c6ae5dfbfb7b5(RC_64337b445a88908182ed34f64cf1399b[] array) {
  RL_9129a40e214c2e67892c6ae5dfbfb7b5 result = new RL_9129a40e214c2e67892c6ae5dfbfb7b5();
result.InnerFromArray(array);
    return result;
}

public static RL_9129a40e214c2e67892c6ae5dfbfb7b5 ToList<T>(T[] array, Func <T, RC_64337b445a88908182ed34f64cf1399b> converter) {
  RL_9129a40e214c2e67892c6ae5dfbfb7b5 result = new RL_9129a40e214c2e67892c6ae5dfbfb7b5();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_9129a40e214c2e67892c6ae5dfbfb7b5 FromRestList<T>(RestList<T> restList, Func <T, RC_64337b445a88908182ed34f64cf1399b> converter) {
  RL_9129a40e214c2e67892c6ae5dfbfb7b5 result = new RL_9129a40e214c2e67892c6ae5dfbfb7b5();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_9129a40e214c2e67892c6ae5dfbfb7b5() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(29,false);
def[1] = new BitArray(39,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_64337b445a88908182ed34f64cf1399b> NewList() {
return new RL_9129a40e214c2e67892c6ae5dfbfb7b5();
}


} // RL_9129a40e214c2e67892c6ae5dfbfb7b5
}

