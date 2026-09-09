namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (Z3dJAToeske+JgPs_Cpxwg)
///  <code>RC_04c362ab7ba29f051f4f0e5fa0df3577</code> that represent
/// s <code>OrderStatusOrderMainRecord</code> <p>Description: </p>
/// </summary>
// Name: OrderStatusOrderMainRecord
public partial struct RC_04c362ab7ba29f051f4f0e5fa0df3577 : ITypedRecord<RC_04c362ab7ba29f051f4f0e5fa0df3577> {
internal static readonly GlobalObjectKey IdOrderStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*3HKdkZJSEuhZevT6wKgI5A");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");

public EN_5eda60810da752f579e01795bb7e0de0EntityRecord ssENOrderStatus;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;


public BitArray OptimizedAttributes;

public RC_04c362ab7ba29f051f4f0e5fa0df3577() {
OptimizedAttributes = null;
ssENOrderStatus = new EN_5eda60810da752f579e01795bb7e0de0EntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(6,false);
    all[1] = new BitArray(29,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderStatus.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENOrderStatus.OptimizedAttributes = value[0];
    ssENOrderMain.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENOrderStatus.OptimizedAttributes;
    all[1] = ssENOrderMain.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENOrderStatus.Read( r, ref index);
ssENOrderMain.Read( r, ref index);
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
public void ReadIM(RC_04c362ab7ba29f051f4f0e5fa0df3577 r) {
this = r;
}


public static bool operator == (RC_04c362ab7ba29f051f4f0e5fa0df3577 a, RC_04c362ab7ba29f051f4f0e5fa0df3577 b) {
if (a.ssENOrderStatus != b.ssENOrderStatus) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
return true;
}

public static bool operator != (RC_04c362ab7ba29f051f4f0e5fa0df3577 a, RC_04c362ab7ba29f051f4f0e5fa0df3577 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_04c362ab7ba29f051f4f0e5fa0df3577)) return false;
return (this == (RC_04c362ab7ba29f051f4f0e5fa0df3577)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderStatus.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderStatus.RecursiveReset();
ssENOrderMain.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderStatus.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
}


public RC_04c362ab7ba29f051f4f0e5fa0df3577 Duplicate() {
RC_04c362ab7ba29f051f4f0e5fa0df3577 t;
t.ssENOrderStatus = (EN_5eda60810da752f579e01795bb7e0de0EntityRecord)this.ssENOrderStatus.Duplicate();
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
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
if (head == "orderstatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderStatus")) variable.Value = ssENOrderStatus; else variable.Optimized = true;
variable.SetFieldName("orderstatus");
} else if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
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
if (key == IdOrderStatus) {
return ssENOrderStatus;
}
if (key == IdOrderMain) {
return ssENOrderMain;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderStatus.Key.AsGuid) {
return ssENOrderStatus;
}
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderStatus.FillFromOther((IRecord) other.AttributeGet(IdOrderStatus));
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
}
} // RC_04c362ab7ba29f051f4f0e5fa0df3577
/// <summary>
/// RecordList type <code>OrderStatusOrderMainRecordList</code> that represents a record list of
///  <code>OrderStatus, OrderMain</code>
/// </summary>
public partial class RL_67e2db3b41beb37bb78f90d8e94803d5 : GenericRecordList<RC_04c362ab7ba29f051f4f0e5fa0df3577>, IEnumerable, IEnumerator {

protected override RC_04c362ab7ba29f051f4f0e5fa0df3577 GetElementDefaultValue() {
return new RC_04c362ab7ba29f051f4f0e5fa0df3577();
}

public T[] ToArray<T>(Func<RC_04c362ab7ba29f051f4f0e5fa0df3577, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_67e2db3b41beb37bb78f90d8e94803d5 recordList, Func<RC_04c362ab7ba29f051f4f0e5fa0df3577, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_67e2db3b41beb37bb78f90d8e94803d5(RC_04c362ab7ba29f051f4f0e5fa0df3577[] array) {
  RL_67e2db3b41beb37bb78f90d8e94803d5 result = new RL_67e2db3b41beb37bb78f90d8e94803d5();
result.InnerFromArray(array);
    return result;
}

public static RL_67e2db3b41beb37bb78f90d8e94803d5 ToList<T>(T[] array, Func <T, RC_04c362ab7ba29f051f4f0e5fa0df3577> converter) {
  RL_67e2db3b41beb37bb78f90d8e94803d5 result = new RL_67e2db3b41beb37bb78f90d8e94803d5();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_67e2db3b41beb37bb78f90d8e94803d5 FromRestList<T>(RestList<T> restList, Func <T, RC_04c362ab7ba29f051f4f0e5fa0df3577> converter) {
  RL_67e2db3b41beb37bb78f90d8e94803d5 result = new RL_67e2db3b41beb37bb78f90d8e94803d5();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_67e2db3b41beb37bb78f90d8e94803d5() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(6,false);
def[1] = new BitArray(29,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_04c362ab7ba29f051f4f0e5fa0df3577> NewList() {
return new RL_67e2db3b41beb37bb78f90d8e94803d5();
}


} // RL_67e2db3b41beb37bb78f90d8e94803d5
}

