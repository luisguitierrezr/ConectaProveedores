namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (DdG_VqZEyEeU+ZYKkLM+AA)
///  <code>RC_42267450aa26a79fb0f0cba424ccbea3</code> that represent
/// s <code>CurrencyUserOrderMainOrderDetailDocumentTypeCompanySupplierRecord</code> <p>Description:
///  </p>
/// </summary>
// Name: CurrencyUserOrderMainOrderDetailDocumentTypeCompanySupplierRecord
public partial struct RC_42267450aa26a79fb0f0cba424ccbea3 : ITypedRecord<RC_42267450aa26a79fb0f0cba424ccbea3> {
internal static readonly GlobalObjectKey IdCurrency = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*L_BoBOY11sygkvMhxdiojg");
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");
internal static readonly GlobalObjectKey IdOrderDetail = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*__4Pf33sZAjriFX+joc3Qw");
internal static readonly GlobalObjectKey IdDocumentType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*1AT3EIne4plVoJ9rG5tWaA");
internal static readonly GlobalObjectKey IdCompany = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bfqhmYH0W+wZCOdwyBtzsQ");
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dOw0SWrcY4B7hMCYX1sSzg");

public EN_327b52812b8badb247bde4975c10d441EntityRecord ssENCurrency;

public ENUserEntityRecord ssENUser;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;

public EN_26f696e758428762fc617e811634d15dEntityRecord ssENOrderDetail;

public EN_a70d553ce1458b3952d039852f258a76EntityRecord ssENDocumentType;

public EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord ssENCompany;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier;


public BitArray OptimizedAttributes;

public RC_42267450aa26a79fb0f0cba424ccbea3() {
OptimizedAttributes = null;
ssENCurrency = new EN_327b52812b8badb247bde4975c10d441EntityRecord();
ssENUser = new ENUserEntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssENOrderDetail = new EN_26f696e758428762fc617e811634d15dEntityRecord();
ssENDocumentType = new EN_a70d553ce1458b3952d039852f258a76EntityRecord();
ssENCompany = new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord();
ssENSupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[7];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(5,false);
    all[2] = new BitArray(29,false);
    all[3] = new BitArray(39,false);
    all[4] = new BitArray(7,false);
    all[5] = new BitArray(11,false);
    all[6] = new BitArray(28,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENCurrency.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENOrderDetail.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENDocumentType.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENCompany.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    ssENSupplier.OptimizedAttributes = GetDefaultOptimizedValues()[6];
    }else{
    ssENCurrency.OptimizedAttributes = value[0];
    ssENUser.OptimizedAttributes = value[1];
    ssENOrderMain.OptimizedAttributes = value[2];
    ssENOrderDetail.OptimizedAttributes = value[3];
    ssENDocumentType.OptimizedAttributes = value[4];
    ssENCompany.OptimizedAttributes = value[5];
    ssENSupplier.OptimizedAttributes = value[6];
    }
}
get{
    BitArray[] all = new BitArray[7];
    all[0] = ssENCurrency.OptimizedAttributes;
    all[1] = ssENUser.OptimizedAttributes;
    all[2] = ssENOrderMain.OptimizedAttributes;
    all[3] = ssENOrderDetail.OptimizedAttributes;
    all[4] = ssENDocumentType.OptimizedAttributes;
    all[5] = ssENCompany.OptimizedAttributes;
    all[6] = ssENSupplier.OptimizedAttributes;
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
ssENUser.Read( r, ref index);
ssENOrderMain.Read( r, ref index);
ssENOrderDetail.Read( r, ref index);
ssENDocumentType.Read( r, ref index);
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
public void ReadIM(RC_42267450aa26a79fb0f0cba424ccbea3 r) {
this = r;
}


public static bool operator == (RC_42267450aa26a79fb0f0cba424ccbea3 a, RC_42267450aa26a79fb0f0cba424ccbea3 b) {
if (a.ssENCurrency != b.ssENCurrency) return false;
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
if (a.ssENOrderDetail != b.ssENOrderDetail) return false;
if (a.ssENDocumentType != b.ssENDocumentType) return false;
if (a.ssENCompany != b.ssENCompany) return false;
if (a.ssENSupplier != b.ssENSupplier) return false;
return true;
}

public static bool operator != (RC_42267450aa26a79fb0f0cba424ccbea3 a, RC_42267450aa26a79fb0f0cba424ccbea3 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_42267450aa26a79fb0f0cba424ccbea3)) return false;
return (this == (RC_42267450aa26a79fb0f0cba424ccbea3)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENCurrency.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
 ^ ssENOrderDetail.GetHashCode()
 ^ ssENDocumentType.GetHashCode()
 ^ ssENCompany.GetHashCode()
 ^ ssENSupplier.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENCurrency.RecursiveReset();
ssENUser.RecursiveReset();
ssENOrderMain.RecursiveReset();
ssENOrderDetail.RecursiveReset();
ssENDocumentType.RecursiveReset();
ssENCompany.RecursiveReset();
ssENSupplier.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENCurrency.InternalRecursiveSave();
ssENUser.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
ssENOrderDetail.InternalRecursiveSave();
ssENDocumentType.InternalRecursiveSave();
ssENCompany.InternalRecursiveSave();
ssENSupplier.InternalRecursiveSave();
}


public RC_42267450aa26a79fb0f0cba424ccbea3 Duplicate() {
RC_42267450aa26a79fb0f0cba424ccbea3 t;
t.ssENCurrency = (EN_327b52812b8badb247bde4975c10d441EntityRecord)this.ssENCurrency.Duplicate();
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
t.ssENOrderDetail = (EN_26f696e758428762fc617e811634d15dEntityRecord)this.ssENOrderDetail.Duplicate();
t.ssENDocumentType = (EN_a70d553ce1458b3952d039852f258a76EntityRecord)this.ssENDocumentType.Duplicate();
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
} else if (head == "user") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User")) variable.Value = ssENUser; else variable.Optimized = true;
variable.SetFieldName("user");
} else if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
} else if (head == "orderdetail") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderDetail")) variable.Value = ssENOrderDetail; else variable.Optimized = true;
variable.SetFieldName("orderdetail");
} else if (head == "documenttype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DocumentType")) variable.Value = ssENDocumentType; else variable.Optimized = true;
variable.SetFieldName("documenttype");
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
if (key == IdUser) {
return ssENUser;
}
if (key == IdOrderMain) {
return ssENOrderMain;
}
if (key == IdOrderDetail) {
return ssENOrderDetail;
}
if (key == IdDocumentType) {
return ssENDocumentType;
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
if (attributeKey == IdUser.Key.AsGuid) {
return ssENUser;
}
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
}
if (attributeKey == IdOrderDetail.Key.AsGuid) {
return ssENOrderDetail;
}
if (attributeKey == IdDocumentType.Key.AsGuid) {
return ssENDocumentType;
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
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
ssENOrderDetail.FillFromOther((IRecord) other.AttributeGet(IdOrderDetail));
ssENDocumentType.FillFromOther((IRecord) other.AttributeGet(IdDocumentType));
ssENCompany.FillFromOther((IRecord) other.AttributeGet(IdCompany));
ssENSupplier.FillFromOther((IRecord) other.AttributeGet(IdSupplier));
}
} // RC_42267450aa26a79fb0f0cba424ccbea3
/// <summary>
/// RecordList type <code>CurrencyUserOrderMainOrderDetailDocumentTypeCompanySupplierRecordList</code>
///  that represents a record list of <code>Currency, User, OrderMain, OrderDetail, DocumentType
/// , Company, Supplier</code>
/// </summary>
public partial class RL_3fb912307e41f6b8b38356a7f29b5100 : GenericRecordList<RC_42267450aa26a79fb0f0cba424ccbea3>, IEnumerable, IEnumerator {

protected override RC_42267450aa26a79fb0f0cba424ccbea3 GetElementDefaultValue() {
return new RC_42267450aa26a79fb0f0cba424ccbea3();
}

public T[] ToArray<T>(Func<RC_42267450aa26a79fb0f0cba424ccbea3, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_3fb912307e41f6b8b38356a7f29b5100 recordList, Func<RC_42267450aa26a79fb0f0cba424ccbea3, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_3fb912307e41f6b8b38356a7f29b5100(RC_42267450aa26a79fb0f0cba424ccbea3[] array) {
  RL_3fb912307e41f6b8b38356a7f29b5100 result = new RL_3fb912307e41f6b8b38356a7f29b5100();
result.InnerFromArray(array);
    return result;
}

public static RL_3fb912307e41f6b8b38356a7f29b5100 ToList<T>(T[] array, Func <T, RC_42267450aa26a79fb0f0cba424ccbea3> converter) {
  RL_3fb912307e41f6b8b38356a7f29b5100 result = new RL_3fb912307e41f6b8b38356a7f29b5100();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_3fb912307e41f6b8b38356a7f29b5100 FromRestList<T>(RestList<T> restList, Func <T, RC_42267450aa26a79fb0f0cba424ccbea3> converter) {
  RL_3fb912307e41f6b8b38356a7f29b5100 result = new RL_3fb912307e41f6b8b38356a7f29b5100();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_3fb912307e41f6b8b38356a7f29b5100() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[7];
def[0] = new BitArray(5,false);
def[1] = new BitArray(5,false);
def[2] = new BitArray(29,false);
def[3] = new BitArray(39,false);
def[4] = new BitArray(7,false);
def[5] = new BitArray(11,false);
def[6] = new BitArray(28,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_42267450aa26a79fb0f0cba424ccbea3> NewList() {
return new RL_3fb912307e41f6b8b38356a7f29b5100();
}


} // RL_3fb912307e41f6b8b38356a7f29b5100
}

