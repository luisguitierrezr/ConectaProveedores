namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (6P9FEH6UV0GNPrJdpBX5fQ)
///  <code>RC_2563c789f5f898fb1c6cb65b6b599fae</code> that represent
/// s
///  <code>CurrencyInvoiceInvoiceStatusOrderAccConceptsOrderRequestFileOrderAccountingOrderMainAccountin
/// gDataTypeRecord</code> <p>Description: </p>
/// </summary>
// Name: CurrencyInvoiceInvoiceStatusOrderAccConceptsOrderRequestFileOrderAccountingOrderMainAccountingDataTypeRecord
public partial struct RC_2563c789f5f898fb1c6cb65b6b599fae : ITypedRecord<RC_2563c789f5f898fb1c6cb65b6b599fae> {
internal static readonly GlobalObjectKey IdCurrency = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*L_BoBOY11sygkvMhxdiojg");
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdInvoiceStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*xRfbbmO_L0X0rCTUGZGpQA");
internal static readonly GlobalObjectKey IdOrderAccConcepts = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*GWia3F+CiO7roBGSrpsYkA");
internal static readonly GlobalObjectKey IdOrderRequestFile = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bBLYcy5yTSvWYtqyvxpy0Q");
internal static readonly GlobalObjectKey IdOrderAccounting = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*OM_CLcG8i2ozjcXqmlxkRg");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");
internal static readonly GlobalObjectKey IdAccountingDataType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*etEiohArUeXSV_ovWJJJnA");

public EN_327b52812b8badb247bde4975c10d441EntityRecord ssENCurrency;

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord ssENInvoiceStatus;

public EN_3e07a23619060cc7dc5624548803f5fdEntityRecord ssENOrderAccConcepts;

public EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord ssENOrderRequestFile;

public EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord ssENOrderAccounting;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;

public EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord ssENAccountingDataType;


public BitArray OptimizedAttributes;

public RC_2563c789f5f898fb1c6cb65b6b599fae() {
OptimizedAttributes = null;
ssENCurrency = new EN_327b52812b8badb247bde4975c10d441EntityRecord();
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENInvoiceStatus = new EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord();
ssENOrderAccConcepts = new EN_3e07a23619060cc7dc5624548803f5fdEntityRecord();
ssENOrderRequestFile = new EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord();
ssENOrderAccounting = new EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssENAccountingDataType = new EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[8];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(24,false);
    all[2] = new BitArray(7,false);
    all[3] = new BitArray(14,false);
    all[4] = new BitArray(17,false);
    all[5] = new BitArray(19,false);
    all[6] = new BitArray(29,false);
    all[7] = new BitArray(5,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENCurrency.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENInvoiceStatus.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENOrderAccConcepts.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENOrderRequestFile.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENOrderAccounting.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[6];
    ssENAccountingDataType.OptimizedAttributes = GetDefaultOptimizedValues()[7];
    }else{
    ssENCurrency.OptimizedAttributes = value[0];
    ssENInvoice.OptimizedAttributes = value[1];
    ssENInvoiceStatus.OptimizedAttributes = value[2];
    ssENOrderAccConcepts.OptimizedAttributes = value[3];
    ssENOrderRequestFile.OptimizedAttributes = value[4];
    ssENOrderAccounting.OptimizedAttributes = value[5];
    ssENOrderMain.OptimizedAttributes = value[6];
    ssENAccountingDataType.OptimizedAttributes = value[7];
    }
}
get{
    BitArray[] all = new BitArray[8];
    all[0] = ssENCurrency.OptimizedAttributes;
    all[1] = ssENInvoice.OptimizedAttributes;
    all[2] = ssENInvoiceStatus.OptimizedAttributes;
    all[3] = ssENOrderAccConcepts.OptimizedAttributes;
    all[4] = ssENOrderRequestFile.OptimizedAttributes;
    all[5] = ssENOrderAccounting.OptimizedAttributes;
    all[6] = ssENOrderMain.OptimizedAttributes;
    all[7] = ssENAccountingDataType.OptimizedAttributes;
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
ssENInvoice.Read( r, ref index);
ssENInvoiceStatus.Read( r, ref index);
ssENOrderAccConcepts.Read( r, ref index);
ssENOrderRequestFile.Read( r, ref index);
ssENOrderAccounting.Read( r, ref index);
ssENOrderMain.Read( r, ref index);
ssENAccountingDataType.Read( r, ref index);
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
public void ReadIM(RC_2563c789f5f898fb1c6cb65b6b599fae r) {
this = r;
}


public static bool operator == (RC_2563c789f5f898fb1c6cb65b6b599fae a, RC_2563c789f5f898fb1c6cb65b6b599fae b) {
if (a.ssENCurrency != b.ssENCurrency) return false;
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENInvoiceStatus != b.ssENInvoiceStatus) return false;
if (a.ssENOrderAccConcepts != b.ssENOrderAccConcepts) return false;
if (a.ssENOrderRequestFile != b.ssENOrderRequestFile) return false;
if (a.ssENOrderAccounting != b.ssENOrderAccounting) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
if (a.ssENAccountingDataType != b.ssENAccountingDataType) return false;
return true;
}

public static bool operator != (RC_2563c789f5f898fb1c6cb65b6b599fae a, RC_2563c789f5f898fb1c6cb65b6b599fae b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_2563c789f5f898fb1c6cb65b6b599fae)) return false;
return (this == (RC_2563c789f5f898fb1c6cb65b6b599fae)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENCurrency.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENInvoiceStatus.GetHashCode()
 ^ ssENOrderAccConcepts.GetHashCode()
 ^ ssENOrderRequestFile.GetHashCode()
 ^ ssENOrderAccounting.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
 ^ ssENAccountingDataType.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENCurrency.RecursiveReset();
ssENInvoice.RecursiveReset();
ssENInvoiceStatus.RecursiveReset();
ssENOrderAccConcepts.RecursiveReset();
ssENOrderRequestFile.RecursiveReset();
ssENOrderAccounting.RecursiveReset();
ssENOrderMain.RecursiveReset();
ssENAccountingDataType.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENCurrency.InternalRecursiveSave();
ssENInvoice.InternalRecursiveSave();
ssENInvoiceStatus.InternalRecursiveSave();
ssENOrderAccConcepts.InternalRecursiveSave();
ssENOrderRequestFile.InternalRecursiveSave();
ssENOrderAccounting.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
ssENAccountingDataType.InternalRecursiveSave();
}


public RC_2563c789f5f898fb1c6cb65b6b599fae Duplicate() {
RC_2563c789f5f898fb1c6cb65b6b599fae t;
t.ssENCurrency = (EN_327b52812b8badb247bde4975c10d441EntityRecord)this.ssENCurrency.Duplicate();
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
t.ssENInvoiceStatus = (EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord)this.ssENInvoiceStatus.Duplicate();
t.ssENOrderAccConcepts = (EN_3e07a23619060cc7dc5624548803f5fdEntityRecord)this.ssENOrderAccConcepts.Duplicate();
t.ssENOrderRequestFile = (EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord)this.ssENOrderRequestFile.Duplicate();
t.ssENOrderAccounting = (EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord)this.ssENOrderAccounting.Duplicate();
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
t.ssENAccountingDataType = (EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord)this.ssENAccountingDataType.Duplicate();
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
} else if (head == "invoice") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Invoice")) variable.Value = ssENInvoice; else variable.Optimized = true;
variable.SetFieldName("invoice");
} else if (head == "invoicestatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceStatus")) variable.Value = ssENInvoiceStatus; else variable.Optimized = true;
variable.SetFieldName("invoicestatus");
} else if (head == "orderaccconcepts") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderAccConcepts")) variable.Value = ssENOrderAccConcepts; else variable.Optimized = true;
variable.SetFieldName("orderaccconcepts");
} else if (head == "orderrequestfile") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderRequestFile")) variable.Value = ssENOrderRequestFile; else variable.Optimized = true;
variable.SetFieldName("orderrequestfile");
} else if (head == "orderaccounting") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderAccounting")) variable.Value = ssENOrderAccounting; else variable.Optimized = true;
variable.SetFieldName("orderaccounting");
} else if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
} else if (head == "accountingdatatype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AccountingDataType")) variable.Value = ssENAccountingDataType; else variable.Optimized = true;
variable.SetFieldName("accountingdatatype");
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
if (key == IdInvoice) {
return ssENInvoice;
}
if (key == IdInvoiceStatus) {
return ssENInvoiceStatus;
}
if (key == IdOrderAccConcepts) {
return ssENOrderAccConcepts;
}
if (key == IdOrderRequestFile) {
return ssENOrderRequestFile;
}
if (key == IdOrderAccounting) {
return ssENOrderAccounting;
}
if (key == IdOrderMain) {
return ssENOrderMain;
}
if (key == IdAccountingDataType) {
return ssENAccountingDataType;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCurrency.Key.AsGuid) {
return ssENCurrency;
}
if (attributeKey == IdInvoice.Key.AsGuid) {
return ssENInvoice;
}
if (attributeKey == IdInvoiceStatus.Key.AsGuid) {
return ssENInvoiceStatus;
}
if (attributeKey == IdOrderAccConcepts.Key.AsGuid) {
return ssENOrderAccConcepts;
}
if (attributeKey == IdOrderRequestFile.Key.AsGuid) {
return ssENOrderRequestFile;
}
if (attributeKey == IdOrderAccounting.Key.AsGuid) {
return ssENOrderAccounting;
}
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
}
if (attributeKey == IdAccountingDataType.Key.AsGuid) {
return ssENAccountingDataType;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENCurrency.FillFromOther((IRecord) other.AttributeGet(IdCurrency));
ssENInvoice.FillFromOther((IRecord) other.AttributeGet(IdInvoice));
ssENInvoiceStatus.FillFromOther((IRecord) other.AttributeGet(IdInvoiceStatus));
ssENOrderAccConcepts.FillFromOther((IRecord) other.AttributeGet(IdOrderAccConcepts));
ssENOrderRequestFile.FillFromOther((IRecord) other.AttributeGet(IdOrderRequestFile));
ssENOrderAccounting.FillFromOther((IRecord) other.AttributeGet(IdOrderAccounting));
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
ssENAccountingDataType.FillFromOther((IRecord) other.AttributeGet(IdAccountingDataType));
}
} // RC_2563c789f5f898fb1c6cb65b6b599fae
/// <summary>
/// RecordList type
///  <code>CurrencyInvoiceInvoiceStatusOrderAccConceptsOrderRequestFileOrderAccountingOrderMainAccountin
/// gDataTypeRecordList</code> that represents a record list of <code>Currency, Invoice, InvoiceStatus,
///  OrderAccConcepts, OrderRequestFile, OrderAccounting, OrderMain, AccountingDataType</code>
/// </summary>
public partial class RL_e127e807f43523243e5e4b1203065583 : GenericRecordList<RC_2563c789f5f898fb1c6cb65b6b599fae>, IEnumerable, IEnumerator {

protected override RC_2563c789f5f898fb1c6cb65b6b599fae GetElementDefaultValue() {
return new RC_2563c789f5f898fb1c6cb65b6b599fae();
}

public T[] ToArray<T>(Func<RC_2563c789f5f898fb1c6cb65b6b599fae, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e127e807f43523243e5e4b1203065583 recordList, Func<RC_2563c789f5f898fb1c6cb65b6b599fae, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e127e807f43523243e5e4b1203065583(RC_2563c789f5f898fb1c6cb65b6b599fae[] array) {
  RL_e127e807f43523243e5e4b1203065583 result = new RL_e127e807f43523243e5e4b1203065583();
result.InnerFromArray(array);
    return result;
}

public static RL_e127e807f43523243e5e4b1203065583 ToList<T>(T[] array, Func <T, RC_2563c789f5f898fb1c6cb65b6b599fae> converter) {
  RL_e127e807f43523243e5e4b1203065583 result = new RL_e127e807f43523243e5e4b1203065583();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e127e807f43523243e5e4b1203065583 FromRestList<T>(RestList<T> restList, Func <T, RC_2563c789f5f898fb1c6cb65b6b599fae> converter) {
  RL_e127e807f43523243e5e4b1203065583 result = new RL_e127e807f43523243e5e4b1203065583();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e127e807f43523243e5e4b1203065583() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[8];
def[0] = new BitArray(5,false);
def[1] = new BitArray(24,false);
def[2] = new BitArray(7,false);
def[3] = new BitArray(14,false);
def[4] = new BitArray(17,false);
def[5] = new BitArray(19,false);
def[6] = new BitArray(29,false);
def[7] = new BitArray(5,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_2563c789f5f898fb1c6cb65b6b599fae> NewList() {
return new RL_e127e807f43523243e5e4b1203065583();
}


} // RL_e127e807f43523243e5e4b1203065583
}

