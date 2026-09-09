namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] ForeignInvoiceUsResult (QQMXL8AqsU6qtpp8L9ElIA)
///  <code>ST_6f620840109ac6f721328b723ec0152cStructure</code> that represent
/// s <code>ForeignInvoiceUsResult</code> <p>Description: </p>
/// </summary>
// Name: ForeignInvoiceUsResult
public partial struct ST_6f620840109ac6f721328b723ec0152cStructure : ITypedRecord<ST_6f620840109ac6f721328b723ec0152cStructure>, OutSystems.Application.Extensibility.DataTypes.IStructure {
internal static readonly GlobalObjectKey IdSuccess = GlobalObjectKey.Parse("Ns9vqbLSGrW_Dp797oBFqA*2BdYgDlgiCt52hen2RbUpw");
internal static readonly GlobalObjectKey IdErrorMessage = GlobalObjectKey.Parse("Ns9vqbLSGrW_Dp797oBFqA*nj3f3UoltZloa0kWjDRsdw");
internal static readonly GlobalObjectKey IdDocumentType = GlobalObjectKey.Parse("Ns9vqbLSGrW_Dp797oBFqA*1FJnEdXTh_HEb_YvGqEgTg");
internal static readonly GlobalObjectKey IdInvoiceNumber = GlobalObjectKey.Parse("Ns9vqbLSGrW_Dp797oBFqA*z93VeTIAtDaBfmojNao2bg");
internal static readonly GlobalObjectKey IdSupplierName = GlobalObjectKey.Parse("Ns9vqbLSGrW_Dp797oBFqA*bzxxfgQLo00h24N7u70t4Q");
internal static readonly GlobalObjectKey IdSupplierTaxId = GlobalObjectKey.Parse("Ns9vqbLSGrW_Dp797oBFqA*t3ksDmSjKJYPa7HoggbRuw");
internal static readonly GlobalObjectKey IdInvoiceDate = GlobalObjectKey.Parse("Ns9vqbLSGrW_Dp797oBFqA*r+TnHTTCcTpAKMcYxbcDRA");
internal static readonly GlobalObjectKey IdTotalAmount = GlobalObjectKey.Parse("Ns9vqbLSGrW_Dp797oBFqA*i4nSDX_Dt8b3WCbyaMqtYQ");
internal static readonly GlobalObjectKey IdCurrency = GlobalObjectKey.Parse("Ns9vqbLSGrW_Dp797oBFqA*vVlVudmK+D2ZnqI2wD8fvg");
internal static readonly GlobalObjectKey IdCustomerNameDetected = GlobalObjectKey.Parse("Ns9vqbLSGrW_Dp797oBFqA*GbwWb92S6etv4y9PppBtgg");
internal static readonly GlobalObjectKey IdCustomerTaxIdDetected = GlobalObjectKey.Parse("Ns9vqbLSGrW_Dp797oBFqA*Ph0zGfAuEd0AqD7ORAZj3Q");
internal static readonly GlobalObjectKey IdCustomerAddressDetected = GlobalObjectKey.Parse("Ns9vqbLSGrW_Dp797oBFqA*oQ652QVS3yPENcXNbLf+Cw");
internal static readonly GlobalObjectKey IdConfidenceScore = GlobalObjectKey.Parse("Ns9vqbLSGrW_Dp797oBFqA*w8ltndiqjHTW_M0yDwEYYA");
internal static readonly GlobalObjectKey IdWarningsText = GlobalObjectKey.Parse("Ns9vqbLSGrW_Dp797oBFqA*9vYRc1du1OmJG8pdLa5npw");
internal static readonly GlobalObjectKey IdRawText = GlobalObjectKey.Parse("Ns9vqbLSGrW_Dp797oBFqA*xNTY0MDJQJ3P3HFuYa8OwQ");

public bool ssSuccess;

public string ssErrorMessage;

public string ssDocumentType;

public string ssInvoiceNumber;

public string ssSupplierName;

public string ssSupplierTaxId;

public string ssInvoiceDate;

public string ssTotalAmount;

public string ssCurrency;

public string ssCustomerNameDetected;

public string ssCustomerTaxIdDetected;

public string ssCustomerAddressDetected;

public decimal ssConfidenceScore;

public string ssWarningsText;

public string ssRawText;


public BitArray OptimizedAttributes;

public ST_6f620840109ac6f721328b723ec0152cStructure() {
OptimizedAttributes = null;
ssSuccess = false;
ssErrorMessage = "";
ssDocumentType = "";
ssInvoiceNumber = "";
ssSupplierName = "";
ssSupplierTaxId = "";
ssInvoiceDate = "";
ssTotalAmount = "";
ssCurrency = "";
ssCustomerNameDetected = "";
ssCustomerTaxIdDetected = "";
ssCustomerAddressDetected = "";
ssConfidenceScore = 0.0M;
ssWarningsText = "";
ssRawText = "";
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
ssSuccess = r.ReadBoolean(index++, "ForeignInvoiceUsResult.Success", false);
ssErrorMessage = r.ReadText(index++, "ForeignInvoiceUsResult.ErrorMessage", "");
ssDocumentType = r.ReadText(index++, "ForeignInvoiceUsResult.DocumentType", "");
ssInvoiceNumber = r.ReadText(index++, "ForeignInvoiceUsResult.InvoiceNumber", "");
ssSupplierName = r.ReadText(index++, "ForeignInvoiceUsResult.SupplierName", "");
ssSupplierTaxId = r.ReadText(index++, "ForeignInvoiceUsResult.SupplierTaxId", "");
ssInvoiceDate = r.ReadText(index++, "ForeignInvoiceUsResult.InvoiceDate", "");
ssTotalAmount = r.ReadText(index++, "ForeignInvoiceUsResult.TotalAmount", "");
ssCurrency = r.ReadText(index++, "ForeignInvoiceUsResult.Currency", "");
ssCustomerNameDetected = r.ReadText(index++, "ForeignInvoiceUsResult.CustomerNameDetected", "");
ssCustomerTaxIdDetected = r.ReadText(index++, "ForeignInvoiceUsResult.CustomerTaxIdDetected", "");
ssCustomerAddressDetected = r.ReadText(index++, "ForeignInvoiceUsResult.CustomerAddressDetected", "");
ssConfidenceScore = r.ReadDecimal(index++, "ForeignInvoiceUsResult.ConfidenceScore", 0.0M);
ssWarningsText = r.ReadText(index++, "ForeignInvoiceUsResult.WarningsText", "");
ssRawText = r.ReadText(index++, "ForeignInvoiceUsResult.RawText", "");
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
public void ReadIM(ST_6f620840109ac6f721328b723ec0152cStructure r) {
this = r;
}


public static bool operator == (ST_6f620840109ac6f721328b723ec0152cStructure a, ST_6f620840109ac6f721328b723ec0152cStructure b) {
if (a.ssSuccess != b.ssSuccess) return false;
if (a.ssErrorMessage != b.ssErrorMessage) return false;
if (a.ssDocumentType != b.ssDocumentType) return false;
if (a.ssInvoiceNumber != b.ssInvoiceNumber) return false;
if (a.ssSupplierName != b.ssSupplierName) return false;
if (a.ssSupplierTaxId != b.ssSupplierTaxId) return false;
if (a.ssInvoiceDate != b.ssInvoiceDate) return false;
if (a.ssTotalAmount != b.ssTotalAmount) return false;
if (a.ssCurrency != b.ssCurrency) return false;
if (a.ssCustomerNameDetected != b.ssCustomerNameDetected) return false;
if (a.ssCustomerTaxIdDetected != b.ssCustomerTaxIdDetected) return false;
if (a.ssCustomerAddressDetected != b.ssCustomerAddressDetected) return false;
if (a.ssConfidenceScore != b.ssConfidenceScore) return false;
if (a.ssWarningsText != b.ssWarningsText) return false;
if (a.ssRawText != b.ssRawText) return false;
return true;
}

public static bool operator != (ST_6f620840109ac6f721328b723ec0152cStructure a, ST_6f620840109ac6f721328b723ec0152cStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_6f620840109ac6f721328b723ec0152cStructure)) return false;
return (this == (ST_6f620840109ac6f721328b723ec0152cStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSuccess.GetHashCode()
 ^ ssErrorMessage.GetHashCode()
 ^ ssDocumentType.GetHashCode()
 ^ ssInvoiceNumber.GetHashCode()
 ^ ssSupplierName.GetHashCode()
 ^ ssSupplierTaxId.GetHashCode()
 ^ ssInvoiceDate.GetHashCode()
 ^ ssTotalAmount.GetHashCode()
 ^ ssCurrency.GetHashCode()
 ^ ssCustomerNameDetected.GetHashCode()
 ^ ssCustomerTaxIdDetected.GetHashCode()
 ^ ssCustomerAddressDetected.GetHashCode()
 ^ ssConfidenceScore.GetHashCode()
 ^ ssWarningsText.GetHashCode()
 ^ ssRawText.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_6f620840109ac6f721328b723ec0152cStructure Duplicate() {
ST_6f620840109ac6f721328b723ec0152cStructure t;
t.ssSuccess = this.ssSuccess;
t.ssErrorMessage = this.ssErrorMessage;
t.ssDocumentType = this.ssDocumentType;
t.ssInvoiceNumber = this.ssInvoiceNumber;
t.ssSupplierName = this.ssSupplierName;
t.ssSupplierTaxId = this.ssSupplierTaxId;
t.ssInvoiceDate = this.ssInvoiceDate;
t.ssTotalAmount = this.ssTotalAmount;
t.ssCurrency = this.ssCurrency;
t.ssCustomerNameDetected = this.ssCustomerNameDetected;
t.ssCustomerTaxIdDetected = this.ssCustomerTaxIdDetected;
t.ssCustomerAddressDetected = this.ssCustomerAddressDetected;
t.ssConfidenceScore = this.ssConfidenceScore;
t.ssWarningsText = this.ssWarningsText;
t.ssRawText = this.ssRawText;
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
if (head == "success") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Success")) variable.Value = ssSuccess; else variable.Optimized = true;
} else if (head == "errormessage") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ErrorMessage")) variable.Value = ssErrorMessage; else variable.Optimized = true;
} else if (head == "documenttype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DocumentType")) variable.Value = ssDocumentType; else variable.Optimized = true;
} else if (head == "invoicenumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceNumber")) variable.Value = ssInvoiceNumber; else variable.Optimized = true;
} else if (head == "suppliername") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SupplierName")) variable.Value = ssSupplierName; else variable.Optimized = true;
} else if (head == "suppliertaxid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SupplierTaxId")) variable.Value = ssSupplierTaxId; else variable.Optimized = true;
} else if (head == "invoicedate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceDate")) variable.Value = ssInvoiceDate; else variable.Optimized = true;
} else if (head == "totalamount") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TotalAmount")) variable.Value = ssTotalAmount; else variable.Optimized = true;
} else if (head == "currency") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Currency")) variable.Value = ssCurrency; else variable.Optimized = true;
} else if (head == "customernamedetected") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CustomerNameDetected")) variable.Value = ssCustomerNameDetected; else variable.Optimized = true;
} else if (head == "customertaxiddetected") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CustomerTaxIdDetected")) variable.Value = ssCustomerTaxIdDetected; else variable.Optimized = true;
} else if (head == "customeraddressdetected") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CustomerAddressDetected")) variable.Value = ssCustomerAddressDetected; else variable.Optimized = true;
} else if (head == "confidencescore") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ConfidenceScore")) variable.Value = ssConfidenceScore; else variable.Optimized = true;
} else if (head == "warningstext") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".WarningsText")) variable.Value = ssWarningsText; else variable.Optimized = true;
} else if (head == "rawtext") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RawText")) variable.Value = ssRawText; else variable.Optimized = true;
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
if (key == IdSuccess) {
return ssSuccess;
}
if (key == IdErrorMessage) {
return ssErrorMessage;
}
if (key == IdDocumentType) {
return ssDocumentType;
}
if (key == IdInvoiceNumber) {
return ssInvoiceNumber;
}
if (key == IdSupplierName) {
return ssSupplierName;
}
if (key == IdSupplierTaxId) {
return ssSupplierTaxId;
}
if (key == IdInvoiceDate) {
return ssInvoiceDate;
}
if (key == IdTotalAmount) {
return ssTotalAmount;
}
if (key == IdCurrency) {
return ssCurrency;
}
if (key == IdCustomerNameDetected) {
return ssCustomerNameDetected;
}
if (key == IdCustomerTaxIdDetected) {
return ssCustomerTaxIdDetected;
}
if (key == IdCustomerAddressDetected) {
return ssCustomerAddressDetected;
}
if (key == IdConfidenceScore) {
return ssConfidenceScore;
}
if (key == IdWarningsText) {
return ssWarningsText;
}
if (key == IdRawText) {
return ssRawText;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSuccess.Key.AsGuid) {
return ssSuccess;
}
if (attributeKey == IdErrorMessage.Key.AsGuid) {
return ssErrorMessage;
}
if (attributeKey == IdDocumentType.Key.AsGuid) {
return ssDocumentType;
}
if (attributeKey == IdInvoiceNumber.Key.AsGuid) {
return ssInvoiceNumber;
}
if (attributeKey == IdSupplierName.Key.AsGuid) {
return ssSupplierName;
}
if (attributeKey == IdSupplierTaxId.Key.AsGuid) {
return ssSupplierTaxId;
}
if (attributeKey == IdInvoiceDate.Key.AsGuid) {
return ssInvoiceDate;
}
if (attributeKey == IdTotalAmount.Key.AsGuid) {
return ssTotalAmount;
}
if (attributeKey == IdCurrency.Key.AsGuid) {
return ssCurrency;
}
if (attributeKey == IdCustomerNameDetected.Key.AsGuid) {
return ssCustomerNameDetected;
}
if (attributeKey == IdCustomerTaxIdDetected.Key.AsGuid) {
return ssCustomerTaxIdDetected;
}
if (attributeKey == IdCustomerAddressDetected.Key.AsGuid) {
return ssCustomerAddressDetected;
}
if (attributeKey == IdConfidenceScore.Key.AsGuid) {
return ssConfidenceScore;
}
if (attributeKey == IdWarningsText.Key.AsGuid) {
return ssWarningsText;
}
if (attributeKey == IdRawText.Key.AsGuid) {
return ssRawText;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSuccess = (bool) other.AttributeGet(IdSuccess);
ssErrorMessage = (string) other.AttributeGet(IdErrorMessage);
ssDocumentType = (string) other.AttributeGet(IdDocumentType);
ssInvoiceNumber = (string) other.AttributeGet(IdInvoiceNumber);
ssSupplierName = (string) other.AttributeGet(IdSupplierName);
ssSupplierTaxId = (string) other.AttributeGet(IdSupplierTaxId);
ssInvoiceDate = (string) other.AttributeGet(IdInvoiceDate);
ssTotalAmount = (string) other.AttributeGet(IdTotalAmount);
ssCurrency = (string) other.AttributeGet(IdCurrency);
ssCustomerNameDetected = (string) other.AttributeGet(IdCustomerNameDetected);
ssCustomerTaxIdDetected = (string) other.AttributeGet(IdCustomerTaxIdDetected);
ssCustomerAddressDetected = (string) other.AttributeGet(IdCustomerAddressDetected);
ssConfidenceScore = (decimal) other.AttributeGet(IdConfidenceScore);
ssWarningsText = (string) other.AttributeGet(IdWarningsText);
ssRawText = (string) other.AttributeGet(IdRawText);
}
public void CopyFrom(OutSystems.Application.Extensibility.DataTypes.IRecord other) {
if (other == null) return;
ssSuccess = (bool) other.GetAttribute(IdSuccess.Key.AsGuid);
ssErrorMessage = (string) other.GetAttribute(IdErrorMessage.Key.AsGuid);
ssDocumentType = (string) other.GetAttribute(IdDocumentType.Key.AsGuid);
ssInvoiceNumber = (string) other.GetAttribute(IdInvoiceNumber.Key.AsGuid);
ssSupplierName = (string) other.GetAttribute(IdSupplierName.Key.AsGuid);
ssSupplierTaxId = (string) other.GetAttribute(IdSupplierTaxId.Key.AsGuid);
ssInvoiceDate = (string) other.GetAttribute(IdInvoiceDate.Key.AsGuid);
ssTotalAmount = (string) other.GetAttribute(IdTotalAmount.Key.AsGuid);
ssCurrency = (string) other.GetAttribute(IdCurrency.Key.AsGuid);
ssCustomerNameDetected = (string) other.GetAttribute(IdCustomerNameDetected.Key.AsGuid);
ssCustomerTaxIdDetected = (string) other.GetAttribute(IdCustomerTaxIdDetected.Key.AsGuid);
ssCustomerAddressDetected = (string) other.GetAttribute(IdCustomerAddressDetected.Key.AsGuid);
ssConfidenceScore = (decimal) other.GetAttribute(IdConfidenceScore.Key.AsGuid);
ssWarningsText = (string) other.GetAttribute(IdWarningsText.Key.AsGuid);
ssRawText = (string) other.GetAttribute(IdRawText.Key.AsGuid);
}
} // ST_6f620840109ac6f721328b723ec0152cStructure
/// <summary>
/// RecordList type <code>ForeignInvoiceUsResultList</code> that represents a record list of
///  <code>ForeignInvoiceUsResult</code>
/// </summary>
public partial class RL_5436309074717fcca1a8e94a0b3b6af8 : GenericRecordList<ST_6f620840109ac6f721328b723ec0152cStructure>, IEnumerable, IEnumerator {

protected override ST_6f620840109ac6f721328b723ec0152cStructure GetElementDefaultValue() {
return new ST_6f620840109ac6f721328b723ec0152cStructure();
}

public T[] ToArray<T>(Func<ST_6f620840109ac6f721328b723ec0152cStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_5436309074717fcca1a8e94a0b3b6af8 recordList, Func<ST_6f620840109ac6f721328b723ec0152cStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_5436309074717fcca1a8e94a0b3b6af8(ST_6f620840109ac6f721328b723ec0152cStructure[] array) {
  RL_5436309074717fcca1a8e94a0b3b6af8 result = new RL_5436309074717fcca1a8e94a0b3b6af8();
result.InnerFromArray(array);
    return result;
}

public static RL_5436309074717fcca1a8e94a0b3b6af8 ToList<T>(T[] array, Func <T, ST_6f620840109ac6f721328b723ec0152cStructure> converter) {
  RL_5436309074717fcca1a8e94a0b3b6af8 result = new RL_5436309074717fcca1a8e94a0b3b6af8();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_5436309074717fcca1a8e94a0b3b6af8 FromRestList<T>(RestList<T> restList, Func <T, ST_6f620840109ac6f721328b723ec0152cStructure> converter) {
  RL_5436309074717fcca1a8e94a0b3b6af8 result = new RL_5436309074717fcca1a8e94a0b3b6af8();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_5436309074717fcca1a8e94a0b3b6af8() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_6f620840109ac6f721328b723ec0152cStructure> NewList() {
return new RL_5436309074717fcca1a8e94a0b3b6af8();
}


} // RL_5436309074717fcca1a8e94a0b3b6af8
}

