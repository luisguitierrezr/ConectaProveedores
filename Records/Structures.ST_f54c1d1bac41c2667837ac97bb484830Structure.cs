namespace ssConectaProveedores {
/// <summary>
/// [Structure] ValidationReport (2a62XBTGY0iwVWb3wHOHCg)
///  <code>ST_f54c1d1bac41c2667837ac97bb484830Structure</code> that represent
/// s <code>ValidationReport</code> <p>Description: </p>
/// </summary>
// Name: ValidationReport
public partial struct ST_f54c1d1bac41c2667837ac97bb484830Structure : ITypedRecord<ST_f54c1d1bac41c2667837ac97bb484830Structure> {
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*iO8kf51o4kqVzf5c1CPHHg");
internal static readonly GlobalObjectKey IdProject = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*GPyXeERFkU2Ap_OjENN+0A");
internal static readonly GlobalObjectKey IdReservePeriod = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*K0nEYnhAD0qgVsJleY57qw");
internal static readonly GlobalObjectKey IdInvoiceNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*PZSdzbTAmEmurKCPRQZdzA");
internal static readonly GlobalObjectKey IdFrequency = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Ltcp6Cv3u0eQ3a0fX06xlA");
internal static readonly GlobalObjectKey IdRequisitionNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*FOik+ffUaECrBSczBPnplg");
internal static readonly GlobalObjectKey IdOrderNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*gQBvod4i4Uq3VsU9ANm5pQ");
internal static readonly GlobalObjectKey IdDeliveryDate = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*sY9nBBsUxUGdgVGwwZ7zHQ");
internal static readonly GlobalObjectKey IdValidationReportItems = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*QwMsSs3s7EezRiSBKVJU_Q");
internal static readonly GlobalObjectKey IdBusinessCat = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*IoCnXE9gmE2WxCNFAjUUmg");
internal static readonly GlobalObjectKey IdBusinessSubcat = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*WvdCLLeSbkCrlejO19oXwg");
internal static readonly GlobalObjectKey IdCharacteristics = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*IyHnEIak5kmQ+sDuPYWzFw");
internal static readonly GlobalObjectKey IdDeliveries = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*sGhljr7v8Um_ajUXruMm7Q");
internal static readonly GlobalObjectKey IdAttachments = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*BTCMH7_AYEad4w19GjsBRw");
internal static readonly GlobalObjectKey IdValidationReportAuthorizations = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*iLsN0z1i30GDeo1+3NuAxw");
internal static readonly GlobalObjectKey IdFolioCreationDate = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*LkUBLZ5fQE2_jsoEf+eYbg");
internal static readonly GlobalObjectKey IdSociety = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*jGi4qhIlbk+4hFBlZjBYDw");
internal static readonly GlobalObjectKey IdPEPElement = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*clP5cHwUA0yDoJegRwPKoQ");
internal static readonly GlobalObjectKey IdDeliverySite = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*8ZhTkemziUu2lN8_P4zP+w");
internal static readonly GlobalObjectKey IdEntryNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*FpWa2M3tTEWE4zO0a2qqCA");
internal static readonly GlobalObjectKey IdEntryDate = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*yUSjr4aWcU6ZgSUJ6u2QaA");

public string ssSupplier;

public string ssProject;

public string ssReservePeriod;

public string ssInvoiceNumber;

public string ssFrequency;

public string ssRequisitionNumber;

public string ssOrderNumber;

public string ssDeliveryDate;

public RL_f0441ae281d3bacc0d1d0acaed8c2549 ssValidationReportItems;

public string ssBusinessCat;

public string ssBusinessSubcat;

public string ssCharacteristics;

public string ssDeliveries;

public string ssAttachments;

public RL_2d1a9f1ebd1dae77afe7dba56f4eb06c ssValidationReportAuthorizations;

public DateTime ssFolioCreationDate;

public string ssSociety;

public string ssPEPElement;

public string ssDeliverySite;

public string ssEntryNumber;

public DateTime ssEntryDate;


public BitArray OptimizedAttributes;

public ST_f54c1d1bac41c2667837ac97bb484830Structure() {
OptimizedAttributes = null;
ssSupplier = "";
ssProject = "";
ssReservePeriod = "";
ssInvoiceNumber = "";
ssFrequency = "";
ssRequisitionNumber = "";
ssOrderNumber = "";
ssDeliveryDate = "";
ssValidationReportItems = new RL_f0441ae281d3bacc0d1d0acaed8c2549();
ssBusinessCat = "";
ssBusinessSubcat = "";
ssCharacteristics = "";
ssDeliveries = "";
ssAttachments = "";
ssValidationReportAuthorizations = new RL_2d1a9f1ebd1dae77afe7dba56f4eb06c();
ssFolioCreationDate = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
ssSociety = "";
ssPEPElement = "";
ssDeliverySite = "";
ssEntryNumber = "";
ssEntryDate = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
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
ssSupplier = r.ReadText(index++, "ValidationReport.Supplier", "");
ssProject = r.ReadText(index++, "ValidationReport.Project", "");
ssReservePeriod = r.ReadText(index++, "ValidationReport.ReservePeriod", "");
ssInvoiceNumber = r.ReadText(index++, "ValidationReport.InvoiceNumber", "");
ssFrequency = r.ReadText(index++, "ValidationReport.Frequency", "");
ssRequisitionNumber = r.ReadText(index++, "ValidationReport.RequisitionNumber", "");
ssOrderNumber = r.ReadText(index++, "ValidationReport.OrderNumber", "");
ssDeliveryDate = r.ReadText(index++, "ValidationReport.DeliveryDate", "");
ssBusinessCat = r.ReadText(index++, "ValidationReport.BusinessCat", "");
ssBusinessSubcat = r.ReadText(index++, "ValidationReport.BusinessSubcat", "");
ssCharacteristics = r.ReadText(index++, "ValidationReport.Characteristics", "");
ssDeliveries = r.ReadText(index++, "ValidationReport.Deliveries", "");
ssAttachments = r.ReadText(index++, "ValidationReport.Attachments", "");
ssFolioCreationDate = r.ReadDate(index++, "ValidationReport.FolioCreationDate", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssSociety = r.ReadText(index++, "ValidationReport.Society", "");
ssPEPElement = r.ReadText(index++, "ValidationReport.PEPElement", "");
ssDeliverySite = r.ReadText(index++, "ValidationReport.DeliverySite", "");
ssEntryNumber = r.ReadText(index++, "ValidationReport.EntryNumber", "");
ssEntryDate = r.ReadDateTime(index++, "ValidationReport.EntryDate", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
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
public void ReadIM(ST_f54c1d1bac41c2667837ac97bb484830Structure r) {
this = r;
}


public static bool operator == (ST_f54c1d1bac41c2667837ac97bb484830Structure a, ST_f54c1d1bac41c2667837ac97bb484830Structure b) {
if (a.ssSupplier != b.ssSupplier) return false;
if (a.ssProject != b.ssProject) return false;
if (a.ssReservePeriod != b.ssReservePeriod) return false;
if (a.ssInvoiceNumber != b.ssInvoiceNumber) return false;
if (a.ssFrequency != b.ssFrequency) return false;
if (a.ssRequisitionNumber != b.ssRequisitionNumber) return false;
if (a.ssOrderNumber != b.ssOrderNumber) return false;
if (a.ssDeliveryDate != b.ssDeliveryDate) return false;
if (a.ssValidationReportItems != b.ssValidationReportItems) return false;
if (a.ssBusinessCat != b.ssBusinessCat) return false;
if (a.ssBusinessSubcat != b.ssBusinessSubcat) return false;
if (a.ssCharacteristics != b.ssCharacteristics) return false;
if (a.ssDeliveries != b.ssDeliveries) return false;
if (a.ssAttachments != b.ssAttachments) return false;
if (a.ssValidationReportAuthorizations != b.ssValidationReportAuthorizations) return false;
if (a.ssFolioCreationDate != b.ssFolioCreationDate) return false;
if (a.ssSociety != b.ssSociety) return false;
if (a.ssPEPElement != b.ssPEPElement) return false;
if (a.ssDeliverySite != b.ssDeliverySite) return false;
if (a.ssEntryNumber != b.ssEntryNumber) return false;
if (a.ssEntryDate != b.ssEntryDate) return false;
return true;
}

public static bool operator != (ST_f54c1d1bac41c2667837ac97bb484830Structure a, ST_f54c1d1bac41c2667837ac97bb484830Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_f54c1d1bac41c2667837ac97bb484830Structure)) return false;
return (this == (ST_f54c1d1bac41c2667837ac97bb484830Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSupplier.GetHashCode()
 ^ ssProject.GetHashCode()
 ^ ssReservePeriod.GetHashCode()
 ^ ssInvoiceNumber.GetHashCode()
 ^ ssFrequency.GetHashCode()
 ^ ssRequisitionNumber.GetHashCode()
 ^ ssOrderNumber.GetHashCode()
 ^ ssDeliveryDate.GetHashCode()
 ^ ssValidationReportItems.GetHashCode()
 ^ ssBusinessCat.GetHashCode()
 ^ ssBusinessSubcat.GetHashCode()
 ^ ssCharacteristics.GetHashCode()
 ^ ssDeliveries.GetHashCode()
 ^ ssAttachments.GetHashCode()
 ^ ssValidationReportAuthorizations.GetHashCode()
 ^ ssFolioCreationDate.GetHashCode()
 ^ ssSociety.GetHashCode()
 ^ ssPEPElement.GetHashCode()
 ^ ssDeliverySite.GetHashCode()
 ^ ssEntryNumber.GetHashCode()
 ^ ssEntryDate.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssValidationReportItems.RecursiveReset();
ssValidationReportAuthorizations.RecursiveReset();
}

public void InternalRecursiveSave() {
ssValidationReportItems.InternalRecursiveSave();
ssValidationReportAuthorizations.InternalRecursiveSave();
}


public ST_f54c1d1bac41c2667837ac97bb484830Structure Duplicate() {
ST_f54c1d1bac41c2667837ac97bb484830Structure t;
t.ssSupplier = this.ssSupplier;
t.ssProject = this.ssProject;
t.ssReservePeriod = this.ssReservePeriod;
t.ssInvoiceNumber = this.ssInvoiceNumber;
t.ssFrequency = this.ssFrequency;
t.ssRequisitionNumber = this.ssRequisitionNumber;
t.ssOrderNumber = this.ssOrderNumber;
t.ssDeliveryDate = this.ssDeliveryDate;
t.ssValidationReportItems = (RL_f0441ae281d3bacc0d1d0acaed8c2549)this.ssValidationReportItems.Duplicate();
t.ssBusinessCat = this.ssBusinessCat;
t.ssBusinessSubcat = this.ssBusinessSubcat;
t.ssCharacteristics = this.ssCharacteristics;
t.ssDeliveries = this.ssDeliveries;
t.ssAttachments = this.ssAttachments;
t.ssValidationReportAuthorizations = (RL_2d1a9f1ebd1dae77afe7dba56f4eb06c)this.ssValidationReportAuthorizations.Duplicate();
t.ssFolioCreationDate = this.ssFolioCreationDate;
t.ssSociety = this.ssSociety;
t.ssPEPElement = this.ssPEPElement;
t.ssDeliverySite = this.ssDeliverySite;
t.ssEntryNumber = this.ssEntryNumber;
t.ssEntryDate = this.ssEntryDate;
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
if (head == "supplier") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Supplier")) variable.Value = ssSupplier; else variable.Optimized = true;
} else if (head == "project") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Project")) variable.Value = ssProject; else variable.Optimized = true;
} else if (head == "reserveperiod") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ReservePeriod")) variable.Value = ssReservePeriod; else variable.Optimized = true;
} else if (head == "invoicenumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceNumber")) variable.Value = ssInvoiceNumber; else variable.Optimized = true;
} else if (head == "frequency") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Frequency")) variable.Value = ssFrequency; else variable.Optimized = true;
} else if (head == "requisitionnumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionNumber")) variable.Value = ssRequisitionNumber; else variable.Optimized = true;
} else if (head == "ordernumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderNumber")) variable.Value = ssOrderNumber; else variable.Optimized = true;
} else if (head == "deliverydate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DeliveryDate")) variable.Value = ssDeliveryDate; else variable.Optimized = true;
} else if (head == "validationreportitems") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ValidationReportItems")) variable.Value = ssValidationReportItems; else variable.Optimized = true;
variable.SetFieldName("validationreportitems");
} else if (head == "businesscat") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BusinessCat")) variable.Value = ssBusinessCat; else variable.Optimized = true;
} else if (head == "businesssubcat") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BusinessSubcat")) variable.Value = ssBusinessSubcat; else variable.Optimized = true;
} else if (head == "characteristics") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Characteristics")) variable.Value = ssCharacteristics; else variable.Optimized = true;
} else if (head == "deliveries") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Deliveries")) variable.Value = ssDeliveries; else variable.Optimized = true;
} else if (head == "attachments") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Attachments")) variable.Value = ssAttachments; else variable.Optimized = true;
} else if (head == "validationreportauthorizations") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ValidationReportAuthorizations")) variable.Value = ssValidationReportAuthorizations; else variable.Optimized = true;
variable.SetFieldName("validationreportauthorizations");
} else if (head == "foliocreationdate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioCreationDate")) variable.Value = ssFolioCreationDate; else variable.Optimized = true;
} else if (head == "society") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Society")) variable.Value = ssSociety; else variable.Optimized = true;
} else if (head == "pepelement") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PEPElement")) variable.Value = ssPEPElement; else variable.Optimized = true;
} else if (head == "deliverysite") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DeliverySite")) variable.Value = ssDeliverySite; else variable.Optimized = true;
} else if (head == "entrynumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EntryNumber")) variable.Value = ssEntryNumber; else variable.Optimized = true;
} else if (head == "entrydate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EntryDate")) variable.Value = ssEntryDate; else variable.Optimized = true;
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
if (key == IdSupplier) {
return ssSupplier;
}
if (key == IdProject) {
return ssProject;
}
if (key == IdReservePeriod) {
return ssReservePeriod;
}
if (key == IdInvoiceNumber) {
return ssInvoiceNumber;
}
if (key == IdFrequency) {
return ssFrequency;
}
if (key == IdRequisitionNumber) {
return ssRequisitionNumber;
}
if (key == IdOrderNumber) {
return ssOrderNumber;
}
if (key == IdDeliveryDate) {
return ssDeliveryDate;
}
if (key == IdValidationReportItems) {
return ssValidationReportItems;
}
if (key == IdBusinessCat) {
return ssBusinessCat;
}
if (key == IdBusinessSubcat) {
return ssBusinessSubcat;
}
if (key == IdCharacteristics) {
return ssCharacteristics;
}
if (key == IdDeliveries) {
return ssDeliveries;
}
if (key == IdAttachments) {
return ssAttachments;
}
if (key == IdValidationReportAuthorizations) {
return ssValidationReportAuthorizations;
}
if (key == IdFolioCreationDate) {
return ssFolioCreationDate;
}
if (key == IdSociety) {
return ssSociety;
}
if (key == IdPEPElement) {
return ssPEPElement;
}
if (key == IdDeliverySite) {
return ssDeliverySite;
}
if (key == IdEntryNumber) {
return ssEntryNumber;
}
if (key == IdEntryDate) {
return ssEntryDate;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSupplier.Key.AsGuid) {
return ssSupplier;
}
if (attributeKey == IdProject.Key.AsGuid) {
return ssProject;
}
if (attributeKey == IdReservePeriod.Key.AsGuid) {
return ssReservePeriod;
}
if (attributeKey == IdInvoiceNumber.Key.AsGuid) {
return ssInvoiceNumber;
}
if (attributeKey == IdFrequency.Key.AsGuid) {
return ssFrequency;
}
if (attributeKey == IdRequisitionNumber.Key.AsGuid) {
return ssRequisitionNumber;
}
if (attributeKey == IdOrderNumber.Key.AsGuid) {
return ssOrderNumber;
}
if (attributeKey == IdDeliveryDate.Key.AsGuid) {
return ssDeliveryDate;
}
if (attributeKey == IdValidationReportItems.Key.AsGuid) {
return ssValidationReportItems;
}
if (attributeKey == IdBusinessCat.Key.AsGuid) {
return ssBusinessCat;
}
if (attributeKey == IdBusinessSubcat.Key.AsGuid) {
return ssBusinessSubcat;
}
if (attributeKey == IdCharacteristics.Key.AsGuid) {
return ssCharacteristics;
}
if (attributeKey == IdDeliveries.Key.AsGuid) {
return ssDeliveries;
}
if (attributeKey == IdAttachments.Key.AsGuid) {
return ssAttachments;
}
if (attributeKey == IdValidationReportAuthorizations.Key.AsGuid) {
return ssValidationReportAuthorizations;
}
if (attributeKey == IdFolioCreationDate.Key.AsGuid) {
return ssFolioCreationDate;
}
if (attributeKey == IdSociety.Key.AsGuid) {
return ssSociety;
}
if (attributeKey == IdPEPElement.Key.AsGuid) {
return ssPEPElement;
}
if (attributeKey == IdDeliverySite.Key.AsGuid) {
return ssDeliverySite;
}
if (attributeKey == IdEntryNumber.Key.AsGuid) {
return ssEntryNumber;
}
if (attributeKey == IdEntryDate.Key.AsGuid) {
return ssEntryDate;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSupplier = (string) other.AttributeGet(IdSupplier);
ssProject = (string) other.AttributeGet(IdProject);
ssReservePeriod = (string) other.AttributeGet(IdReservePeriod);
ssInvoiceNumber = (string) other.AttributeGet(IdInvoiceNumber);
ssFrequency = (string) other.AttributeGet(IdFrequency);
ssRequisitionNumber = (string) other.AttributeGet(IdRequisitionNumber);
ssOrderNumber = (string) other.AttributeGet(IdOrderNumber);
ssDeliveryDate = (string) other.AttributeGet(IdDeliveryDate);
ssValidationReportItems = new RL_f0441ae281d3bacc0d1d0acaed8c2549();
ssValidationReportItems.FillFromOther((IOSList) other.AttributeGet(IdValidationReportItems));
ssBusinessCat = (string) other.AttributeGet(IdBusinessCat);
ssBusinessSubcat = (string) other.AttributeGet(IdBusinessSubcat);
ssCharacteristics = (string) other.AttributeGet(IdCharacteristics);
ssDeliveries = (string) other.AttributeGet(IdDeliveries);
ssAttachments = (string) other.AttributeGet(IdAttachments);
ssValidationReportAuthorizations = new RL_2d1a9f1ebd1dae77afe7dba56f4eb06c();
ssValidationReportAuthorizations.FillFromOther((IOSList) other.AttributeGet(IdValidationReportAuthorizations));
ssFolioCreationDate = (DateTime) other.AttributeGet(IdFolioCreationDate);
ssSociety = (string) other.AttributeGet(IdSociety);
ssPEPElement = (string) other.AttributeGet(IdPEPElement);
ssDeliverySite = (string) other.AttributeGet(IdDeliverySite);
ssEntryNumber = (string) other.AttributeGet(IdEntryNumber);
ssEntryDate = (DateTime) other.AttributeGet(IdEntryDate);
}
} // ST_f54c1d1bac41c2667837ac97bb484830Structure
/// <summary>
/// RecordList type <code>ValidationReportList</code> that represents a record list of
///  <code>ValidationReport</code>
/// </summary>
public partial class RL_99970ecbfe62c21ccd9fb62c3aba729e : GenericRecordList<ST_f54c1d1bac41c2667837ac97bb484830Structure>, IEnumerable, IEnumerator {

protected override ST_f54c1d1bac41c2667837ac97bb484830Structure GetElementDefaultValue() {
return new ST_f54c1d1bac41c2667837ac97bb484830Structure();
}

public T[] ToArray<T>(Func<ST_f54c1d1bac41c2667837ac97bb484830Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_99970ecbfe62c21ccd9fb62c3aba729e recordList, Func<ST_f54c1d1bac41c2667837ac97bb484830Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_99970ecbfe62c21ccd9fb62c3aba729e(ST_f54c1d1bac41c2667837ac97bb484830Structure[] array) {
  RL_99970ecbfe62c21ccd9fb62c3aba729e result = new RL_99970ecbfe62c21ccd9fb62c3aba729e();
result.InnerFromArray(array);
    return result;
}

public static RL_99970ecbfe62c21ccd9fb62c3aba729e ToList<T>(T[] array, Func <T, ST_f54c1d1bac41c2667837ac97bb484830Structure> converter) {
  RL_99970ecbfe62c21ccd9fb62c3aba729e result = new RL_99970ecbfe62c21ccd9fb62c3aba729e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_99970ecbfe62c21ccd9fb62c3aba729e FromRestList<T>(RestList<T> restList, Func <T, ST_f54c1d1bac41c2667837ac97bb484830Structure> converter) {
  RL_99970ecbfe62c21ccd9fb62c3aba729e result = new RL_99970ecbfe62c21ccd9fb62c3aba729e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_99970ecbfe62c21ccd9fb62c3aba729e() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_f54c1d1bac41c2667837ac97bb484830Structure> NewList() {
return new RL_99970ecbfe62c21ccd9fb62c3aba729e();
}


} // RL_99970ecbfe62c21ccd9fb62c3aba729e
}

