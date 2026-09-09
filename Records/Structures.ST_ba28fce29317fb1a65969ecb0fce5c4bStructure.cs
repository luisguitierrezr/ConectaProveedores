namespace ssConectaProveedores {
/// <summary>
/// [Structure] ProposalTempData (ZeCGKvjdxEyxKDYpf0LzJA)
///  <code>ST_ba28fce29317fb1a65969ecb0fce5c4bStructure</code> that represent
/// s <code>ProposalTempData</code> <p>Description: Proposal Temp Data Struct.</p>
/// </summary>
// Name: ProposalTempData
public partial struct ST_ba28fce29317fb1a65969ecb0fce5c4bStructure : ITypedRecord<ST_ba28fce29317fb1a65969ecb0fce5c4bStructure> {
internal static readonly GlobalObjectKey IdProposalTypeId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*DvNwpVY7MEmlIpthz7IVEA");
internal static readonly GlobalObjectKey IdProposalType = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*NViLS_5qNEyHJX21M5zXGA");
internal static readonly GlobalObjectKey IdPaymentDate = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*IMmtwMJJlUqkNQVINlvhbw");
internal static readonly GlobalObjectKey IdProposalDate = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*nXYcCpZbBEK2LyRfnsLX3w");
internal static readonly GlobalObjectKey IdPaymentDateText = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*TkD9d0xTJEu0Ck9ZvR2Nfw");
internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*vJRSevd2o0GP3lYf+9lFbQ");
internal static readonly GlobalObjectKey IdBankCode = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*lNMXEkGBckKyq9oFxM3YLw");
internal static readonly GlobalObjectKey IdBankId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*THw2dKsgxUu_ITwbUWVWQw");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*I1Mf0iwD20CwZC0zPA0PGQ");
internal static readonly GlobalObjectKey IdRegionId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*109nzWHxR0WINHujEbt2MA");
internal static readonly GlobalObjectKey IdDivisionFI = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*8Gt1DPJ7yU2v7tIabaV0mQ");
internal static readonly GlobalObjectKey IdTotalProposalLines = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*GeT62BwUu0OKq9a6sgX_RQ");
internal static readonly GlobalObjectKey IdTotalValueML = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*HivnBnagMkStZRRIAjT7pA");
internal static readonly GlobalObjectKey IdTotalValueMD = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*WChCUbCYrkWFoy9HVsOGcw");
internal static readonly GlobalObjectKey IdCurrencyId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*HmZitkSPDkaQ6VPt7uW1wg");
internal static readonly GlobalObjectKey IdCurrencyCode = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*QPTD6Cao30iSTgxcMxGKcw");
internal static readonly GlobalObjectKey IdCommissionsAndLeasesFileStructList = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*LP+1z0A1a0Wn1gggqsV0rQ");

public int ssProposalTypeId;

public string ssProposalType;

public DateTime ssPaymentDate;

public DateTime ssProposalDate;

public string ssPaymentDateText;

public string ssName;

public string ssBankCode;

public long ssBankId;

public string ssRegion;

public long ssRegionId;

public string ssDivisionFI;

public int ssTotalProposalLines;

public decimal ssTotalValueML;

public decimal ssTotalValueMD;

public string ssCurrencyId;

public string ssCurrencyCode;

public RL_238f83286c67570510312c00ff7c1c1b ssCommissionsAndLeasesFileStructList;


public BitArray OptimizedAttributes;

public ST_ba28fce29317fb1a65969ecb0fce5c4bStructure() {
OptimizedAttributes = null;
ssProposalTypeId = 0;
ssProposalType = "";
ssPaymentDate = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
ssProposalDate = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
ssPaymentDateText = "";
ssName = "";
ssBankCode = "";
ssBankId = 0L;
ssRegion = "";
ssRegionId = 0L;
ssDivisionFI = "";
ssTotalProposalLines = 0;
ssTotalValueML = 0.0M;
ssTotalValueMD = 0.0M;
ssCurrencyId = "";
ssCurrencyCode = "";
ssCommissionsAndLeasesFileStructList = new RL_238f83286c67570510312c00ff7c1c1b();
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
ssProposalTypeId = r.ReadEntityReference(index++, "ProposalTempData.ProposalTypeId", 0);
ssProposalType = r.ReadText(index++, "ProposalTempData.ProposalType", "");
ssPaymentDate = r.ReadDate(index++, "ProposalTempData.PaymentDate", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssProposalDate = r.ReadDate(index++, "ProposalTempData.ProposalDate", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssPaymentDateText = r.ReadText(index++, "ProposalTempData.PaymentDateText", "");
ssName = r.ReadText(index++, "ProposalTempData.Name", "");
ssBankCode = r.ReadText(index++, "ProposalTempData.BankCode", "");
ssBankId = r.ReadEntityReferenceLongInteger(index++, "ProposalTempData.BankId", 0L);
ssRegion = r.ReadText(index++, "ProposalTempData.Region", "");
ssRegionId = r.ReadEntityReferenceLongInteger(index++, "ProposalTempData.RegionId", 0L);
ssDivisionFI = r.ReadText(index++, "ProposalTempData.DivisionFI", "");
ssTotalProposalLines = r.ReadInteger(index++, "ProposalTempData.TotalProposalLines", 0);
ssTotalValueML = r.ReadDecimal(index++, "ProposalTempData.TotalValueML", 0.0M);
ssTotalValueMD = r.ReadDecimal(index++, "ProposalTempData.TotalValueMD", 0.0M);
ssCurrencyId = r.ReadEntityReferenceText(index++, "ProposalTempData.CurrencyId", "");
ssCurrencyCode = r.ReadText(index++, "ProposalTempData.CurrencyCode", "");
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
public void ReadIM(ST_ba28fce29317fb1a65969ecb0fce5c4bStructure r) {
this = r;
}


public static bool operator == (ST_ba28fce29317fb1a65969ecb0fce5c4bStructure a, ST_ba28fce29317fb1a65969ecb0fce5c4bStructure b) {
if (a.ssProposalTypeId != b.ssProposalTypeId) return false;
if (a.ssProposalType != b.ssProposalType) return false;
if (a.ssPaymentDate != b.ssPaymentDate) return false;
if (a.ssProposalDate != b.ssProposalDate) return false;
if (a.ssPaymentDateText != b.ssPaymentDateText) return false;
if (a.ssName != b.ssName) return false;
if (a.ssBankCode != b.ssBankCode) return false;
if (a.ssBankId != b.ssBankId) return false;
if (a.ssRegion != b.ssRegion) return false;
if (a.ssRegionId != b.ssRegionId) return false;
if (a.ssDivisionFI != b.ssDivisionFI) return false;
if (a.ssTotalProposalLines != b.ssTotalProposalLines) return false;
if (a.ssTotalValueML != b.ssTotalValueML) return false;
if (a.ssTotalValueMD != b.ssTotalValueMD) return false;
if (a.ssCurrencyId != b.ssCurrencyId) return false;
if (a.ssCurrencyCode != b.ssCurrencyCode) return false;
if (a.ssCommissionsAndLeasesFileStructList != b.ssCommissionsAndLeasesFileStructList) return false;
return true;
}

public static bool operator != (ST_ba28fce29317fb1a65969ecb0fce5c4bStructure a, ST_ba28fce29317fb1a65969ecb0fce5c4bStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_ba28fce29317fb1a65969ecb0fce5c4bStructure)) return false;
return (this == (ST_ba28fce29317fb1a65969ecb0fce5c4bStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssProposalTypeId.GetHashCode()
 ^ ssProposalType.GetHashCode()
 ^ ssPaymentDate.GetHashCode()
 ^ ssProposalDate.GetHashCode()
 ^ ssPaymentDateText.GetHashCode()
 ^ ssName.GetHashCode()
 ^ ssBankCode.GetHashCode()
 ^ ssBankId.GetHashCode()
 ^ ssRegion.GetHashCode()
 ^ ssRegionId.GetHashCode()
 ^ ssDivisionFI.GetHashCode()
 ^ ssTotalProposalLines.GetHashCode()
 ^ ssTotalValueML.GetHashCode()
 ^ ssTotalValueMD.GetHashCode()
 ^ ssCurrencyId.GetHashCode()
 ^ ssCurrencyCode.GetHashCode()
 ^ ssCommissionsAndLeasesFileStructList.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssCommissionsAndLeasesFileStructList.RecursiveReset();
}

public void InternalRecursiveSave() {
ssCommissionsAndLeasesFileStructList.InternalRecursiveSave();
}


public ST_ba28fce29317fb1a65969ecb0fce5c4bStructure Duplicate() {
ST_ba28fce29317fb1a65969ecb0fce5c4bStructure t;
t.ssProposalTypeId = this.ssProposalTypeId;
t.ssProposalType = this.ssProposalType;
t.ssPaymentDate = this.ssPaymentDate;
t.ssProposalDate = this.ssProposalDate;
t.ssPaymentDateText = this.ssPaymentDateText;
t.ssName = this.ssName;
t.ssBankCode = this.ssBankCode;
t.ssBankId = this.ssBankId;
t.ssRegion = this.ssRegion;
t.ssRegionId = this.ssRegionId;
t.ssDivisionFI = this.ssDivisionFI;
t.ssTotalProposalLines = this.ssTotalProposalLines;
t.ssTotalValueML = this.ssTotalValueML;
t.ssTotalValueMD = this.ssTotalValueMD;
t.ssCurrencyId = this.ssCurrencyId;
t.ssCurrencyCode = this.ssCurrencyCode;
t.ssCommissionsAndLeasesFileStructList = (RL_238f83286c67570510312c00ff7c1c1b)this.ssCommissionsAndLeasesFileStructList.Duplicate();
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
if (head == "proposaltypeid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalTypeId")) variable.Value = ssProposalTypeId; else variable.Optimized = true;
} else if (head == "proposaltype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalType")) variable.Value = ssProposalType; else variable.Optimized = true;
} else if (head == "paymentdate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PaymentDate")) variable.Value = ssPaymentDate; else variable.Optimized = true;
} else if (head == "proposaldate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalDate")) variable.Value = ssProposalDate; else variable.Optimized = true;
} else if (head == "paymentdatetext") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PaymentDateText")) variable.Value = ssPaymentDateText; else variable.Optimized = true;
} else if (head == "name") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
} else if (head == "bankcode") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BankCode")) variable.Value = ssBankCode; else variable.Optimized = true;
} else if (head == "bankid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BankId")) variable.Value = ssBankId; else variable.Optimized = true;
} else if (head == "region") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Region")) variable.Value = ssRegion; else variable.Optimized = true;
} else if (head == "regionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RegionId")) variable.Value = ssRegionId; else variable.Optimized = true;
} else if (head == "divisionfi") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DivisionFI")) variable.Value = ssDivisionFI; else variable.Optimized = true;
} else if (head == "totalproposallines") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TotalProposalLines")) variable.Value = ssTotalProposalLines; else variable.Optimized = true;
} else if (head == "totalvalueml") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TotalValueML")) variable.Value = ssTotalValueML; else variable.Optimized = true;
} else if (head == "totalvaluemd") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TotalValueMD")) variable.Value = ssTotalValueMD; else variable.Optimized = true;
} else if (head == "currencyid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CurrencyId")) variable.Value = ssCurrencyId; else variable.Optimized = true;
} else if (head == "currencycode") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CurrencyCode")) variable.Value = ssCurrencyCode; else variable.Optimized = true;
} else if (head == "commissionsandleasesfilestructlist") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CommissionsAndLeasesFileStructList")) variable.Value = ssCommissionsAndLeasesFileStructList; else variable.Optimized = true;
variable.SetFieldName("commissionsandleasesfilestructlist");
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
if (key == IdProposalTypeId) {
return ssProposalTypeId;
}
if (key == IdProposalType) {
return ssProposalType;
}
if (key == IdPaymentDate) {
return ssPaymentDate;
}
if (key == IdProposalDate) {
return ssProposalDate;
}
if (key == IdPaymentDateText) {
return ssPaymentDateText;
}
if (key == IdName) {
return ssName;
}
if (key == IdBankCode) {
return ssBankCode;
}
if (key == IdBankId) {
return ssBankId;
}
if (key == IdRegion) {
return ssRegion;
}
if (key == IdRegionId) {
return ssRegionId;
}
if (key == IdDivisionFI) {
return ssDivisionFI;
}
if (key == IdTotalProposalLines) {
return ssTotalProposalLines;
}
if (key == IdTotalValueML) {
return ssTotalValueML;
}
if (key == IdTotalValueMD) {
return ssTotalValueMD;
}
if (key == IdCurrencyId) {
return ssCurrencyId;
}
if (key == IdCurrencyCode) {
return ssCurrencyCode;
}
if (key == IdCommissionsAndLeasesFileStructList) {
return ssCommissionsAndLeasesFileStructList;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdProposalTypeId.Key.AsGuid) {
return ssProposalTypeId;
}
if (attributeKey == IdProposalType.Key.AsGuid) {
return ssProposalType;
}
if (attributeKey == IdPaymentDate.Key.AsGuid) {
return ssPaymentDate;
}
if (attributeKey == IdProposalDate.Key.AsGuid) {
return ssProposalDate;
}
if (attributeKey == IdPaymentDateText.Key.AsGuid) {
return ssPaymentDateText;
}
if (attributeKey == IdName.Key.AsGuid) {
return ssName;
}
if (attributeKey == IdBankCode.Key.AsGuid) {
return ssBankCode;
}
if (attributeKey == IdBankId.Key.AsGuid) {
return ssBankId;
}
if (attributeKey == IdRegion.Key.AsGuid) {
return ssRegion;
}
if (attributeKey == IdRegionId.Key.AsGuid) {
return ssRegionId;
}
if (attributeKey == IdDivisionFI.Key.AsGuid) {
return ssDivisionFI;
}
if (attributeKey == IdTotalProposalLines.Key.AsGuid) {
return ssTotalProposalLines;
}
if (attributeKey == IdTotalValueML.Key.AsGuid) {
return ssTotalValueML;
}
if (attributeKey == IdTotalValueMD.Key.AsGuid) {
return ssTotalValueMD;
}
if (attributeKey == IdCurrencyId.Key.AsGuid) {
return ssCurrencyId;
}
if (attributeKey == IdCurrencyCode.Key.AsGuid) {
return ssCurrencyCode;
}
if (attributeKey == IdCommissionsAndLeasesFileStructList.Key.AsGuid) {
return ssCommissionsAndLeasesFileStructList;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssProposalTypeId = (int) other.AttributeGet(IdProposalTypeId);
ssProposalType = (string) other.AttributeGet(IdProposalType);
ssPaymentDate = (DateTime) other.AttributeGet(IdPaymentDate);
ssProposalDate = (DateTime) other.AttributeGet(IdProposalDate);
ssPaymentDateText = (string) other.AttributeGet(IdPaymentDateText);
ssName = (string) other.AttributeGet(IdName);
ssBankCode = (string) other.AttributeGet(IdBankCode);
ssBankId = (long) other.AttributeGet(IdBankId);
ssRegion = (string) other.AttributeGet(IdRegion);
ssRegionId = (long) other.AttributeGet(IdRegionId);
ssDivisionFI = (string) other.AttributeGet(IdDivisionFI);
ssTotalProposalLines = (int) other.AttributeGet(IdTotalProposalLines);
ssTotalValueML = (decimal) other.AttributeGet(IdTotalValueML);
ssTotalValueMD = (decimal) other.AttributeGet(IdTotalValueMD);
ssCurrencyId = (string) other.AttributeGet(IdCurrencyId);
ssCurrencyCode = (string) other.AttributeGet(IdCurrencyCode);
ssCommissionsAndLeasesFileStructList = new RL_238f83286c67570510312c00ff7c1c1b();
ssCommissionsAndLeasesFileStructList.FillFromOther((IOSList) other.AttributeGet(IdCommissionsAndLeasesFileStructList));
}
} // ST_ba28fce29317fb1a65969ecb0fce5c4bStructure
/// <summary>
/// RecordList type <code>ProposalTempDataList</code> that represents a record list of
///  <code>ProposalTempData</code>
/// </summary>
public partial class RL_78c5fa2a2ab2367162406803cb4174b4 : GenericRecordList<ST_ba28fce29317fb1a65969ecb0fce5c4bStructure>, IEnumerable, IEnumerator {

protected override ST_ba28fce29317fb1a65969ecb0fce5c4bStructure GetElementDefaultValue() {
return new ST_ba28fce29317fb1a65969ecb0fce5c4bStructure();
}

public T[] ToArray<T>(Func<ST_ba28fce29317fb1a65969ecb0fce5c4bStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_78c5fa2a2ab2367162406803cb4174b4 recordList, Func<ST_ba28fce29317fb1a65969ecb0fce5c4bStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_78c5fa2a2ab2367162406803cb4174b4(ST_ba28fce29317fb1a65969ecb0fce5c4bStructure[] array) {
  RL_78c5fa2a2ab2367162406803cb4174b4 result = new RL_78c5fa2a2ab2367162406803cb4174b4();
result.InnerFromArray(array);
    return result;
}

public static RL_78c5fa2a2ab2367162406803cb4174b4 ToList<T>(T[] array, Func <T, ST_ba28fce29317fb1a65969ecb0fce5c4bStructure> converter) {
  RL_78c5fa2a2ab2367162406803cb4174b4 result = new RL_78c5fa2a2ab2367162406803cb4174b4();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_78c5fa2a2ab2367162406803cb4174b4 FromRestList<T>(RestList<T> restList, Func <T, ST_ba28fce29317fb1a65969ecb0fce5c4bStructure> converter) {
  RL_78c5fa2a2ab2367162406803cb4174b4 result = new RL_78c5fa2a2ab2367162406803cb4174b4();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_78c5fa2a2ab2367162406803cb4174b4() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_ba28fce29317fb1a65969ecb0fce5c4bStructure> NewList() {
return new RL_78c5fa2a2ab2367162406803cb4174b4();
}


} // RL_78c5fa2a2ab2367162406803cb4174b4
}

