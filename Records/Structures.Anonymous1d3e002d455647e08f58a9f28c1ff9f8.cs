namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (LQA+HVZF4EePWKnyjB_5+A)
///  <code>RC_d95294610b1c7b76b1445c6a23286bc4</code> that represent
/// s <code>CurrencyOrderStatusOrderMainCompanySupplierRecord</code> <p>Description: </p>
/// </summary>
// Name: CurrencyOrderStatusOrderMainCompanySupplierRecord
public partial struct RC_d95294610b1c7b76b1445c6a23286bc4 : ITypedRecord<RC_d95294610b1c7b76b1445c6a23286bc4> {
internal static readonly GlobalObjectKey IdCurrency = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*L_BoBOY11sygkvMhxdiojg");
internal static readonly GlobalObjectKey IdOrderStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*3HKdkZJSEuhZevT6wKgI5A");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");
internal static readonly GlobalObjectKey IdCompany = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bfqhmYH0W+wZCOdwyBtzsQ");
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dOw0SWrcY4B7hMCYX1sSzg");

public EN_327b52812b8badb247bde4975c10d441EntityRecord ssENCurrency;

public EN_5eda60810da752f579e01795bb7e0de0EntityRecord ssENOrderStatus;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;

public EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord ssENCompany;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier;


public BitArray OptimizedAttributes;

public RC_d95294610b1c7b76b1445c6a23286bc4() {
OptimizedAttributes = null;
ssENCurrency = new EN_327b52812b8badb247bde4975c10d441EntityRecord();
ssENOrderStatus = new EN_5eda60810da752f579e01795bb7e0de0EntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssENCompany = new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord();
ssENSupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[5];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(6,false);
    all[2] = new BitArray(29,false);
    all[3] = new BitArray(11,false);
    all[4] = new BitArray(28,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENCurrency.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENOrderStatus.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENCompany.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENSupplier.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    }else{
    ssENCurrency.OptimizedAttributes = value[0];
    ssENOrderStatus.OptimizedAttributes = value[1];
    ssENOrderMain.OptimizedAttributes = value[2];
    ssENCompany.OptimizedAttributes = value[3];
    ssENSupplier.OptimizedAttributes = value[4];
    }
}
get{
    BitArray[] all = new BitArray[5];
    all[0] = ssENCurrency.OptimizedAttributes;
    all[1] = ssENOrderStatus.OptimizedAttributes;
    all[2] = ssENOrderMain.OptimizedAttributes;
    all[3] = ssENCompany.OptimizedAttributes;
    all[4] = ssENSupplier.OptimizedAttributes;
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
ssENCompany.Read( r, ref index);
ssENSupplier.Read( r, ref index);
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
public void ReadIM(RC_d95294610b1c7b76b1445c6a23286bc4 r) {
this = r;
}


public static bool operator == (RC_d95294610b1c7b76b1445c6a23286bc4 a, RC_d95294610b1c7b76b1445c6a23286bc4 b) {
if (a.ssENCurrency != b.ssENCurrency) return false;
if (a.ssENOrderStatus != b.ssENOrderStatus) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
if (a.ssENCompany != b.ssENCompany) return false;
if (a.ssENSupplier != b.ssENSupplier) return false;
return true;
}

public static bool operator != (RC_d95294610b1c7b76b1445c6a23286bc4 a, RC_d95294610b1c7b76b1445c6a23286bc4 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_d95294610b1c7b76b1445c6a23286bc4)) return false;
return (this == (RC_d95294610b1c7b76b1445c6a23286bc4)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENCurrency.GetHashCode()
 ^ ssENOrderStatus.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
 ^ ssENCompany.GetHashCode()
 ^ ssENSupplier.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENCurrency.RecursiveReset();
ssENOrderStatus.RecursiveReset();
ssENOrderMain.RecursiveReset();
ssENCompany.RecursiveReset();
ssENSupplier.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENCurrency.InternalRecursiveSave();
ssENOrderStatus.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
ssENCompany.InternalRecursiveSave();
ssENSupplier.InternalRecursiveSave();
}


public RC_d95294610b1c7b76b1445c6a23286bc4 Duplicate() {
RC_d95294610b1c7b76b1445c6a23286bc4 t;
t.ssENCurrency = (EN_327b52812b8badb247bde4975c10d441EntityRecord)this.ssENCurrency.Duplicate();
t.ssENOrderStatus = (EN_5eda60810da752f579e01795bb7e0de0EntityRecord)this.ssENOrderStatus.Duplicate();
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
t.ssENCompany = (EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord)this.ssENCompany.Duplicate();
t.ssENSupplier = (EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord)this.ssENSupplier.Duplicate();
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
} else if (head == "company") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Company")) variable.Value = ssENCompany; else variable.Optimized = true;
variable.SetFieldName("company");
} else if (head == "supplier") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Supplier")) variable.Value = ssENSupplier; else variable.Optimized = true;
variable.SetFieldName("supplier");
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
if (key == IdCompany) {
return ssENCompany;
}
if (key == IdSupplier) {
return ssENSupplier;
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
if (attributeKey == IdCompany.Key.AsGuid) {
return ssENCompany;
}
if (attributeKey == IdSupplier.Key.AsGuid) {
return ssENSupplier;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENCurrency.FillFromOther((IRecord) other.AttributeGet(IdCurrency));
ssENOrderStatus.FillFromOther((IRecord) other.AttributeGet(IdOrderStatus));
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
ssENCompany.FillFromOther((IRecord) other.AttributeGet(IdCompany));
ssENSupplier.FillFromOther((IRecord) other.AttributeGet(IdSupplier));
}
} // RC_d95294610b1c7b76b1445c6a23286bc4
/// <summary>
/// RecordList type <code>CurrencyOrderStatusOrderMainCompanySupplierRecordList</code> that represents
///  a record list of <code>Currency, OrderStatus, OrderMain, Company, Supplier</code>
/// </summary>
public partial class RL_22e659721c63481b25b29a0491fd3d7f : GenericRecordList<RC_d95294610b1c7b76b1445c6a23286bc4>, IEnumerable, IEnumerator {

protected override RC_d95294610b1c7b76b1445c6a23286bc4 GetElementDefaultValue() {
return new RC_d95294610b1c7b76b1445c6a23286bc4();
}

public T[] ToArray<T>(Func<RC_d95294610b1c7b76b1445c6a23286bc4, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_22e659721c63481b25b29a0491fd3d7f recordList, Func<RC_d95294610b1c7b76b1445c6a23286bc4, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_22e659721c63481b25b29a0491fd3d7f(RC_d95294610b1c7b76b1445c6a23286bc4[] array) {
  RL_22e659721c63481b25b29a0491fd3d7f result = new RL_22e659721c63481b25b29a0491fd3d7f();
result.InnerFromArray(array);
    return result;
}

public static RL_22e659721c63481b25b29a0491fd3d7f ToList<T>(T[] array, Func <T, RC_d95294610b1c7b76b1445c6a23286bc4> converter) {
  RL_22e659721c63481b25b29a0491fd3d7f result = new RL_22e659721c63481b25b29a0491fd3d7f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_22e659721c63481b25b29a0491fd3d7f FromRestList<T>(RestList<T> restList, Func <T, RC_d95294610b1c7b76b1445c6a23286bc4> converter) {
  RL_22e659721c63481b25b29a0491fd3d7f result = new RL_22e659721c63481b25b29a0491fd3d7f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_22e659721c63481b25b29a0491fd3d7f() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[5];
def[0] = new BitArray(5,false);
def[1] = new BitArray(6,false);
def[2] = new BitArray(29,false);
def[3] = new BitArray(11,false);
def[4] = new BitArray(28,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_d95294610b1c7b76b1445c6a23286bc4> NewList() {
return new RL_22e659721c63481b25b29a0491fd3d7f();
}


} // RL_22e659721c63481b25b29a0491fd3d7f
}

