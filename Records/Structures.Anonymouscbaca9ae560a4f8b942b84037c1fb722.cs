namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (rqmsywpWi0+UK4QDfB+3Ig)
///  <code>RC_aaba1a35921d1afc1af21b1865cba418</code> that represents <code>OrderServiceRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: OrderServiceRecord
public partial struct RC_aaba1a35921d1afc1af21b1865cba418 : ITypedRecord<RC_aaba1a35921d1afc1af21b1865cba418> {
internal static readonly GlobalObjectKey IdOrderService = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRq6qh2S_Boa8hsYZcukGA");

public EN_476685ea0a242c4f2681d09188dc12dfEntityRecord ssENOrderService;


public static implicit operator EN_476685ea0a242c4f2681d09188dc12dfEntityRecord( RC_aaba1a35921d1afc1af21b1865cba418 r) {
return r.ssENOrderService;
}

public static implicit operator RC_aaba1a35921d1afc1af21b1865cba418 (EN_476685ea0a242c4f2681d09188dc12dfEntityRecord r) {
RC_aaba1a35921d1afc1af21b1865cba418 res = new RC_aaba1a35921d1afc1af21b1865cba418 ();
res.ssENOrderService = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENOrderService.ChangedAttributes = value;
}
get {
    return ssENOrderService.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_aaba1a35921d1afc1af21b1865cba418() {
OptimizedAttributes = null;
ssENOrderService = new EN_476685ea0a242c4f2681d09188dc12dfEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(7,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderService.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENOrderService.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENOrderService.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENOrderService.Read( r, ref index);
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
public void ReadIM(RC_aaba1a35921d1afc1af21b1865cba418 r) {
this = r;
}


public static bool operator == (RC_aaba1a35921d1afc1af21b1865cba418 a, RC_aaba1a35921d1afc1af21b1865cba418 b) {
if (a.ssENOrderService != b.ssENOrderService) return false;
return true;
}

public static bool operator != (RC_aaba1a35921d1afc1af21b1865cba418 a, RC_aaba1a35921d1afc1af21b1865cba418 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_aaba1a35921d1afc1af21b1865cba418)) return false;
return (this == (RC_aaba1a35921d1afc1af21b1865cba418)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderService.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderService.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderService.InternalRecursiveSave();
}


public RC_aaba1a35921d1afc1af21b1865cba418 Duplicate() {
RC_aaba1a35921d1afc1af21b1865cba418 t;
t.ssENOrderService = (EN_476685ea0a242c4f2681d09188dc12dfEntityRecord)this.ssENOrderService.Duplicate();
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
if (head == "orderservice") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderService")) variable.Value = ssENOrderService; else variable.Optimized = true;
variable.SetFieldName("orderservice");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENOrderService.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENOrderService.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdOrderService) {
return ssENOrderService;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderService.Key.AsGuid) {
return ssENOrderService;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderService.FillFromOther((IRecord) other.AttributeGet(IdOrderService));
}
} // RC_aaba1a35921d1afc1af21b1865cba418
/// <summary>
/// RecordList type <code>OrderServiceRecordList</code> that represents a record list of
///  <code>OrderService</code>
/// </summary>
public partial class RL_5b4ba3283dc95d0e2a1e0a402c1ef134 : GenericRecordList<RC_aaba1a35921d1afc1af21b1865cba418>, IEnumerable, IEnumerator {

protected override RC_aaba1a35921d1afc1af21b1865cba418 GetElementDefaultValue() {
return new RC_aaba1a35921d1afc1af21b1865cba418();
}

public T[] ToArray<T>(Func<RC_aaba1a35921d1afc1af21b1865cba418, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_5b4ba3283dc95d0e2a1e0a402c1ef134 recordList, Func<RC_aaba1a35921d1afc1af21b1865cba418, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_5b4ba3283dc95d0e2a1e0a402c1ef134(RC_aaba1a35921d1afc1af21b1865cba418[] array) {
  RL_5b4ba3283dc95d0e2a1e0a402c1ef134 result = new RL_5b4ba3283dc95d0e2a1e0a402c1ef134();
result.InnerFromArray(array);
    return result;
}

public static RL_5b4ba3283dc95d0e2a1e0a402c1ef134 ToList<T>(T[] array, Func <T, RC_aaba1a35921d1afc1af21b1865cba418> converter) {
  RL_5b4ba3283dc95d0e2a1e0a402c1ef134 result = new RL_5b4ba3283dc95d0e2a1e0a402c1ef134();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_5b4ba3283dc95d0e2a1e0a402c1ef134 FromRestList<T>(RestList<T> restList, Func <T, RC_aaba1a35921d1afc1af21b1865cba418> converter) {
  RL_5b4ba3283dc95d0e2a1e0a402c1ef134 result = new RL_5b4ba3283dc95d0e2a1e0a402c1ef134();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_5b4ba3283dc95d0e2a1e0a402c1ef134() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(7,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_aaba1a35921d1afc1af21b1865cba418> NewList() {
return new RL_5b4ba3283dc95d0e2a1e0a402c1ef134();
}


} // RL_5b4ba3283dc95d0e2a1e0a402c1ef134
}

