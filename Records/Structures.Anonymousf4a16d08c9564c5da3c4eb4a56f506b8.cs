namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (CG2h9FbJXUyjxOtKVvUGuA)
///  <code>RC_cbbe4b608ba4cd678dd3afd544ca547e</code> that represent
/// s <code>OrderStatusOrderMainCompanyRecord</code> <p>Description: </p>
/// </summary>
// Name: OrderStatusOrderMainCompanyRecord
public partial struct RC_cbbe4b608ba4cd678dd3afd544ca547e : ITypedRecord<RC_cbbe4b608ba4cd678dd3afd544ca547e> {
internal static readonly GlobalObjectKey IdOrderStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*3HKdkZJSEuhZevT6wKgI5A");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");
internal static readonly GlobalObjectKey IdCompany = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bfqhmYH0W+wZCOdwyBtzsQ");

public EN_5eda60810da752f579e01795bb7e0de0EntityRecord ssENOrderStatus;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;

public EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord ssENCompany;


public BitArray OptimizedAttributes;

public RC_cbbe4b608ba4cd678dd3afd544ca547e() {
OptimizedAttributes = null;
ssENOrderStatus = new EN_5eda60810da752f579e01795bb7e0de0EntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssENCompany = new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(6,false);
    all[1] = new BitArray(29,false);
    all[2] = new BitArray(11,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderStatus.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENCompany.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENOrderStatus.OptimizedAttributes = value[0];
    ssENOrderMain.OptimizedAttributes = value[1];
    ssENCompany.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENOrderStatus.OptimizedAttributes;
    all[1] = ssENOrderMain.OptimizedAttributes;
    all[2] = ssENCompany.OptimizedAttributes;
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
ssENCompany.Read( r, ref index);
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
public void ReadIM(RC_cbbe4b608ba4cd678dd3afd544ca547e r) {
this = r;
}


public static bool operator == (RC_cbbe4b608ba4cd678dd3afd544ca547e a, RC_cbbe4b608ba4cd678dd3afd544ca547e b) {
if (a.ssENOrderStatus != b.ssENOrderStatus) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
if (a.ssENCompany != b.ssENCompany) return false;
return true;
}

public static bool operator != (RC_cbbe4b608ba4cd678dd3afd544ca547e a, RC_cbbe4b608ba4cd678dd3afd544ca547e b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_cbbe4b608ba4cd678dd3afd544ca547e)) return false;
return (this == (RC_cbbe4b608ba4cd678dd3afd544ca547e)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderStatus.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
 ^ ssENCompany.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderStatus.RecursiveReset();
ssENOrderMain.RecursiveReset();
ssENCompany.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderStatus.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
ssENCompany.InternalRecursiveSave();
}


public RC_cbbe4b608ba4cd678dd3afd544ca547e Duplicate() {
RC_cbbe4b608ba4cd678dd3afd544ca547e t;
t.ssENOrderStatus = (EN_5eda60810da752f579e01795bb7e0de0EntityRecord)this.ssENOrderStatus.Duplicate();
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
t.ssENCompany = (EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord)this.ssENCompany.Duplicate();
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
} else if (head == "company") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Company")) variable.Value = ssENCompany; else variable.Optimized = true;
variable.SetFieldName("company");
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
if (key == IdCompany) {
return ssENCompany;
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
if (attributeKey == IdCompany.Key.AsGuid) {
return ssENCompany;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderStatus.FillFromOther((IRecord) other.AttributeGet(IdOrderStatus));
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
ssENCompany.FillFromOther((IRecord) other.AttributeGet(IdCompany));
}
} // RC_cbbe4b608ba4cd678dd3afd544ca547e
/// <summary>
/// RecordList type <code>OrderStatusOrderMainCompanyRecordList</code> that represents a record list of
///  <code>OrderStatus, OrderMain, Company</code>
/// </summary>
public partial class RL_823234b28f8a1e65f461ac57ab48bc32 : GenericRecordList<RC_cbbe4b608ba4cd678dd3afd544ca547e>, IEnumerable, IEnumerator {

protected override RC_cbbe4b608ba4cd678dd3afd544ca547e GetElementDefaultValue() {
return new RC_cbbe4b608ba4cd678dd3afd544ca547e();
}

public T[] ToArray<T>(Func<RC_cbbe4b608ba4cd678dd3afd544ca547e, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_823234b28f8a1e65f461ac57ab48bc32 recordList, Func<RC_cbbe4b608ba4cd678dd3afd544ca547e, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_823234b28f8a1e65f461ac57ab48bc32(RC_cbbe4b608ba4cd678dd3afd544ca547e[] array) {
  RL_823234b28f8a1e65f461ac57ab48bc32 result = new RL_823234b28f8a1e65f461ac57ab48bc32();
result.InnerFromArray(array);
    return result;
}

public static RL_823234b28f8a1e65f461ac57ab48bc32 ToList<T>(T[] array, Func <T, RC_cbbe4b608ba4cd678dd3afd544ca547e> converter) {
  RL_823234b28f8a1e65f461ac57ab48bc32 result = new RL_823234b28f8a1e65f461ac57ab48bc32();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_823234b28f8a1e65f461ac57ab48bc32 FromRestList<T>(RestList<T> restList, Func <T, RC_cbbe4b608ba4cd678dd3afd544ca547e> converter) {
  RL_823234b28f8a1e65f461ac57ab48bc32 result = new RL_823234b28f8a1e65f461ac57ab48bc32();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_823234b28f8a1e65f461ac57ab48bc32() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(6,false);
def[1] = new BitArray(29,false);
def[2] = new BitArray(11,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_cbbe4b608ba4cd678dd3afd544ca547e> NewList() {
return new RL_823234b28f8a1e65f461ac57ab48bc32();
}


} // RL_823234b28f8a1e65f461ac57ab48bc32
}

