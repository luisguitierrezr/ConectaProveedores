namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (ElsK3bpW+kS1yINz2I7i+A)
///  <code>RC_d14c83cafc2c8c4853d5f866ece1c59b</code> that represent
/// s <code>CurrencyOrderStatusOrderMainQuantidadeEntregadaQuantidadeTotalCompanyRecord</code>
///  <p>Description: </p>
/// </summary>
// Name: CurrencyOrderStatusOrderMainQuantidadeEntregadaQuantidadeTotalCompanyRecord
public partial struct RC_d14c83cafc2c8c4853d5f866ece1c59b : ITypedRecord<RC_d14c83cafc2c8c4853d5f866ece1c59b> {
internal static readonly GlobalObjectKey IdCurrency = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*L_BoBOY11sygkvMhxdiojg");
internal static readonly GlobalObjectKey IdOrderStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*3HKdkZJSEuhZevT6wKgI5A");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");
internal static readonly GlobalObjectKey IdQuantidadeEntregada = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*aa3sXG4tYN2x8iHwzTXH4g");
internal static readonly GlobalObjectKey IdQuantidadeTotal = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*rBjGPtSFv6SLT2WGcIydCw");
internal static readonly GlobalObjectKey IdCompany = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bfqhmYH0W+wZCOdwyBtzsQ");

public EN_327b52812b8badb247bde4975c10d441EntityRecord ssENCurrency;

public EN_5eda60810da752f579e01795bb7e0de0EntityRecord ssENOrderStatus;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;

public ST_18874ac0b41f9a239dad794ccac4f8d3Structure ssSTQuantidadeEntregada;

public ST_18874ac0b41f9a239dad794ccac4f8d3Structure ssSTQuantidadeTotal;

public EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord ssENCompany;


public BitArray OptimizedAttributes;

public RC_d14c83cafc2c8c4853d5f866ece1c59b() {
OptimizedAttributes = null;
ssENCurrency = new EN_327b52812b8badb247bde4975c10d441EntityRecord();
ssENOrderStatus = new EN_5eda60810da752f579e01795bb7e0de0EntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssSTQuantidadeEntregada = new ST_18874ac0b41f9a239dad794ccac4f8d3Structure();
ssSTQuantidadeTotal = new ST_18874ac0b41f9a239dad794ccac4f8d3Structure();
ssENCompany = new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[6];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(6,false);
    all[2] = new BitArray(29,false);
    all[3] = null;
    all[4] = null;
    all[5] = new BitArray(11,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENCurrency.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENOrderStatus.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENCompany.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    }else{
    ssENCurrency.OptimizedAttributes = value[0];
    ssENOrderStatus.OptimizedAttributes = value[1];
    ssENOrderMain.OptimizedAttributes = value[2];
    ssSTQuantidadeEntregada.OptimizedAttributes = value[3];
    ssSTQuantidadeTotal.OptimizedAttributes = value[4];
    ssENCompany.OptimizedAttributes = value[5];
    }
}
get{
    BitArray[] all = new BitArray[6];
    all[0] = ssENCurrency.OptimizedAttributes;
    all[1] = ssENOrderStatus.OptimizedAttributes;
    all[2] = ssENOrderMain.OptimizedAttributes;
    all[3] = null;
    all[4] = null;
    all[5] = ssENCompany.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENCurrency.Read( r, ref index);
ssENOrderStatus.Read( r, ref index);
ssENOrderMain.Read( r, ref index);
ssSTQuantidadeEntregada.Read( r, ref index);
ssSTQuantidadeTotal.Read( r, ref index);
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
public void ReadIM(RC_d14c83cafc2c8c4853d5f866ece1c59b r) {
this = r;
}


public static bool operator == (RC_d14c83cafc2c8c4853d5f866ece1c59b a, RC_d14c83cafc2c8c4853d5f866ece1c59b b) {
if (a.ssENCurrency != b.ssENCurrency) return false;
if (a.ssENOrderStatus != b.ssENOrderStatus) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
if (a.ssSTQuantidadeEntregada != b.ssSTQuantidadeEntregada) return false;
if (a.ssSTQuantidadeTotal != b.ssSTQuantidadeTotal) return false;
if (a.ssENCompany != b.ssENCompany) return false;
return true;
}

public static bool operator != (RC_d14c83cafc2c8c4853d5f866ece1c59b a, RC_d14c83cafc2c8c4853d5f866ece1c59b b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_d14c83cafc2c8c4853d5f866ece1c59b)) return false;
return (this == (RC_d14c83cafc2c8c4853d5f866ece1c59b)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENCurrency.GetHashCode()
 ^ ssENOrderStatus.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
 ^ ssSTQuantidadeEntregada.GetHashCode()
 ^ ssSTQuantidadeTotal.GetHashCode()
 ^ ssENCompany.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENCurrency.RecursiveReset();
ssENOrderStatus.RecursiveReset();
ssENOrderMain.RecursiveReset();
ssSTQuantidadeEntregada.RecursiveReset();
ssSTQuantidadeTotal.RecursiveReset();
ssENCompany.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENCurrency.InternalRecursiveSave();
ssENOrderStatus.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
ssSTQuantidadeEntregada.InternalRecursiveSave();
ssSTQuantidadeTotal.InternalRecursiveSave();
ssENCompany.InternalRecursiveSave();
}


public RC_d14c83cafc2c8c4853d5f866ece1c59b Duplicate() {
RC_d14c83cafc2c8c4853d5f866ece1c59b t;
t.ssENCurrency = (EN_327b52812b8badb247bde4975c10d441EntityRecord)this.ssENCurrency.Duplicate();
t.ssENOrderStatus = (EN_5eda60810da752f579e01795bb7e0de0EntityRecord)this.ssENOrderStatus.Duplicate();
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
t.ssSTQuantidadeEntregada = (ST_18874ac0b41f9a239dad794ccac4f8d3Structure)this.ssSTQuantidadeEntregada.Duplicate();
t.ssSTQuantidadeTotal = (ST_18874ac0b41f9a239dad794ccac4f8d3Structure)this.ssSTQuantidadeTotal.Duplicate();
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
if (head == "currency") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Currency")) variable.Value = ssENCurrency; else variable.Optimized = true;
variable.SetFieldName("currency");
} else if (head == "orderstatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderStatus")) variable.Value = ssENOrderStatus; else variable.Optimized = true;
variable.SetFieldName("orderstatus");
} else if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
} else if (head == "quantidadeentregada") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".QuantidadeEntregada")) variable.Value = ssSTQuantidadeEntregada; else variable.Optimized = true;
variable.SetFieldName("quantidadeentregada");
} else if (head == "quantidadetotal") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".QuantidadeTotal")) variable.Value = ssSTQuantidadeTotal; else variable.Optimized = true;
variable.SetFieldName("quantidadetotal");
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
if (key == IdCurrency) {
return ssENCurrency;
}
if (key == IdOrderStatus) {
return ssENOrderStatus;
}
if (key == IdOrderMain) {
return ssENOrderMain;
}
if (key == IdQuantidadeEntregada) {
return ssSTQuantidadeEntregada;
}
if (key == IdQuantidadeTotal) {
return ssSTQuantidadeTotal;
}
if (key == IdCompany) {
return ssENCompany;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCurrency.Key.AsGuid) {
return ssENCurrency;
}
if (attributeKey == IdOrderStatus.Key.AsGuid) {
return ssENOrderStatus;
}
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
}
if (attributeKey == IdQuantidadeEntregada.Key.AsGuid) {
return ssSTQuantidadeEntregada;
}
if (attributeKey == IdQuantidadeTotal.Key.AsGuid) {
return ssSTQuantidadeTotal;
}
if (attributeKey == IdCompany.Key.AsGuid) {
return ssENCompany;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENCurrency.FillFromOther((IRecord) other.AttributeGet(IdCurrency));
ssENOrderStatus.FillFromOther((IRecord) other.AttributeGet(IdOrderStatus));
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
ssSTQuantidadeEntregada.FillFromOther((IRecord) other.AttributeGet(IdQuantidadeEntregada));
ssSTQuantidadeTotal.FillFromOther((IRecord) other.AttributeGet(IdQuantidadeTotal));
ssENCompany.FillFromOther((IRecord) other.AttributeGet(IdCompany));
}
} // RC_d14c83cafc2c8c4853d5f866ece1c59b
/// <summary>
/// RecordList type
///  <code>CurrencyOrderStatusOrderMainQuantidadeEntregadaQuantidadeTotalCompanyRecordList</code> tha
/// t represents a record list of <code>Currency, OrderStatus, OrderMain, Decimal, Decimal,
///  Company</code>
/// </summary>
public partial class RL_ba76bc23b46b20e6625cad46f2aea8e4 : GenericRecordList<RC_d14c83cafc2c8c4853d5f866ece1c59b>, IEnumerable, IEnumerator {

protected override RC_d14c83cafc2c8c4853d5f866ece1c59b GetElementDefaultValue() {
return new RC_d14c83cafc2c8c4853d5f866ece1c59b();
}

public T[] ToArray<T>(Func<RC_d14c83cafc2c8c4853d5f866ece1c59b, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ba76bc23b46b20e6625cad46f2aea8e4 recordList, Func<RC_d14c83cafc2c8c4853d5f866ece1c59b, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ba76bc23b46b20e6625cad46f2aea8e4(RC_d14c83cafc2c8c4853d5f866ece1c59b[] array) {
  RL_ba76bc23b46b20e6625cad46f2aea8e4 result = new RL_ba76bc23b46b20e6625cad46f2aea8e4();
result.InnerFromArray(array);
    return result;
}

public static RL_ba76bc23b46b20e6625cad46f2aea8e4 ToList<T>(T[] array, Func <T, RC_d14c83cafc2c8c4853d5f866ece1c59b> converter) {
  RL_ba76bc23b46b20e6625cad46f2aea8e4 result = new RL_ba76bc23b46b20e6625cad46f2aea8e4();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ba76bc23b46b20e6625cad46f2aea8e4 FromRestList<T>(RestList<T> restList, Func <T, RC_d14c83cafc2c8c4853d5f866ece1c59b> converter) {
  RL_ba76bc23b46b20e6625cad46f2aea8e4 result = new RL_ba76bc23b46b20e6625cad46f2aea8e4();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ba76bc23b46b20e6625cad46f2aea8e4() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[6];
def[0] = new BitArray(5,false);
def[1] = new BitArray(6,false);
def[2] = new BitArray(29,false);
def[3] = null;
def[4] = null;
def[5] = new BitArray(11,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_d14c83cafc2c8c4853d5f866ece1c59b> NewList() {
return new RL_ba76bc23b46b20e6625cad46f2aea8e4();
}


} // RL_ba76bc23b46b20e6625cad46f2aea8e4
}

