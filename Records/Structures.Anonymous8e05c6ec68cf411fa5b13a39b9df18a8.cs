namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (7MYFjs9oH0GlsTo5ud8YqA)
///  <code>RC_e8009f28f7e0bc48d03bef2643bd6906</code> that represents <code>ExchangeRateRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ExchangeRateRecord
public partial struct RC_e8009f28f7e0bc48d03bef2643bd6906 : ITypedRecord<RC_e8009f28f7e0bc48d03bef2643bd6906> {
internal static readonly GlobalObjectKey IdExchangeRate = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*KJ8A6OD3SLzQO+8mQ71pBg");

public decimal ssExchangeRate;


public BitArray OptimizedAttributes;

public RC_e8009f28f7e0bc48d03bef2643bd6906() {
OptimizedAttributes = null;
ssExchangeRate = 0.0M;
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
ssExchangeRate = r.ReadDecimal(index++, "ExchangeRateRecord.ExchangeRate", 0.0M);
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
public void ReadIM(RC_e8009f28f7e0bc48d03bef2643bd6906 r) {
this = r;
}


public static bool operator == (RC_e8009f28f7e0bc48d03bef2643bd6906 a, RC_e8009f28f7e0bc48d03bef2643bd6906 b) {
if (a.ssExchangeRate != b.ssExchangeRate) return false;
return true;
}

public static bool operator != (RC_e8009f28f7e0bc48d03bef2643bd6906 a, RC_e8009f28f7e0bc48d03bef2643bd6906 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_e8009f28f7e0bc48d03bef2643bd6906)) return false;
return (this == (RC_e8009f28f7e0bc48d03bef2643bd6906)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssExchangeRate.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_e8009f28f7e0bc48d03bef2643bd6906 Duplicate() {
RC_e8009f28f7e0bc48d03bef2643bd6906 t;
t.ssExchangeRate = this.ssExchangeRate;
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
if (head == "exchangerate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ExchangeRate")) variable.Value = ssExchangeRate; else variable.Optimized = true;
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
if (key == IdExchangeRate) {
return ssExchangeRate;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdExchangeRate.Key.AsGuid) {
return ssExchangeRate;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssExchangeRate = (decimal) other.AttributeGet(IdExchangeRate);
}
} // RC_e8009f28f7e0bc48d03bef2643bd6906
/// <summary>
/// RecordList type <code>ExchangeRateRecordList</code> that represents a record list of
///  <code>Decimal</code>
/// </summary>
public partial class RL_06217d1a1f91440a5a69e4163e3e2c6f : GenericRecordList<RC_e8009f28f7e0bc48d03bef2643bd6906>, IEnumerable, IEnumerator {

protected override RC_e8009f28f7e0bc48d03bef2643bd6906 GetElementDefaultValue() {
return new RC_e8009f28f7e0bc48d03bef2643bd6906();
}

public T[] ToArray<T>(Func<RC_e8009f28f7e0bc48d03bef2643bd6906, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_06217d1a1f91440a5a69e4163e3e2c6f recordList, Func<RC_e8009f28f7e0bc48d03bef2643bd6906, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_06217d1a1f91440a5a69e4163e3e2c6f(RC_e8009f28f7e0bc48d03bef2643bd6906[] array) {
  RL_06217d1a1f91440a5a69e4163e3e2c6f result = new RL_06217d1a1f91440a5a69e4163e3e2c6f();
result.InnerFromArray(array);
    return result;
}

public static RL_06217d1a1f91440a5a69e4163e3e2c6f ToList<T>(T[] array, Func <T, RC_e8009f28f7e0bc48d03bef2643bd6906> converter) {
  RL_06217d1a1f91440a5a69e4163e3e2c6f result = new RL_06217d1a1f91440a5a69e4163e3e2c6f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_06217d1a1f91440a5a69e4163e3e2c6f FromRestList<T>(RestList<T> restList, Func <T, RC_e8009f28f7e0bc48d03bef2643bd6906> converter) {
  RL_06217d1a1f91440a5a69e4163e3e2c6f result = new RL_06217d1a1f91440a5a69e4163e3e2c6f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_06217d1a1f91440a5a69e4163e3e2c6f() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_e8009f28f7e0bc48d03bef2643bd6906> NewList() {
return new RL_06217d1a1f91440a5a69e4163e3e2c6f();
}


} // RL_06217d1a1f91440a5a69e4163e3e2c6f
}

