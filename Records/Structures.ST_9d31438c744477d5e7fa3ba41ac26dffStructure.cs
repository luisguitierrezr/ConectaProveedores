namespace ssConectaProveedores {
/// <summary>
/// [Structure] FolioQImport (0nQc3a9acUieJxKXQV32eg)
///  <code>ST_9d31438c744477d5e7fa3ba41ac26dffStructure</code> that represents <code>FolioQImport</code
/// > <p>Description: </p>
/// </summary>
// Name: FolioQImport
public partial struct ST_9d31438c744477d5e7fa3ba41ac26dffStructure : ITypedRecord<ST_9d31438c744477d5e7fa3ba41ac26dffStructure> {
internal static readonly GlobalObjectKey IdNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*iBeYEaX3zU22Xv8KPm9CBg");
internal static readonly GlobalObjectKey IdOrder = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*xMNuklvGgkWabtSjWsR1qA");
internal static readonly GlobalObjectKey IdAttachments = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*v_TzfLyHJEasBC5iFdIu+A");
internal static readonly GlobalObjectKey IdPositions = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*BROlWRxBRkWTXe81Mymo2w");
internal static readonly GlobalObjectKey IdDelivery_date = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*2g0nnYMe2kO+7RN6nHmiqQ");
internal static readonly GlobalObjectKey IdInvoiceDelivery = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*IpIgcXTO3UCoOdEsSo8XAQ");
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*cyh+HhB6H0WSOlJ24xol3g");
internal static readonly GlobalObjectKey IdInvoice_pdf = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*SY8hUMUjfEmx3HpU+Ejwkg");
internal static readonly GlobalObjectKey IdInvoice_xml = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*UzTq7a7MBEyn4BrS1gR0mw");
internal static readonly GlobalObjectKey IdPep = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*I6EOKwZZtkWh9GfF2Ds_9Q");
internal static readonly GlobalObjectKey IdSite_id = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*iglDMXThDkK2hXt7olluNQ");
internal static readonly GlobalObjectKey IdSite_name = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*xXelleB9iECZMViFoYV5HQ");

public string ssNumber;

public string ssOrder;

public string ssAttachments;

public string ssPositions;

public string ssDelivery_date;

public string ssInvoiceDelivery;

public string ssUser;

public string ssInvoice_pdf;

public string ssInvoice_xml;

public string ssPep;

public string ssSite_id;

public string ssSite_name;


public BitArray OptimizedAttributes;

public ST_9d31438c744477d5e7fa3ba41ac26dffStructure() {
OptimizedAttributes = null;
ssNumber = "";
ssOrder = "";
ssAttachments = "";
ssPositions = "";
ssDelivery_date = "";
ssInvoiceDelivery = "";
ssUser = "";
ssInvoice_pdf = "";
ssInvoice_xml = "";
ssPep = "";
ssSite_id = "";
ssSite_name = "";
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
ssNumber = r.ReadText(index++, "FolioQImport.Number", "");
ssOrder = r.ReadText(index++, "FolioQImport.Order", "");
ssAttachments = r.ReadText(index++, "FolioQImport.Attachments", "");
ssPositions = r.ReadText(index++, "FolioQImport.Positions", "");
ssDelivery_date = r.ReadText(index++, "FolioQImport.Delivery_date", "");
ssInvoiceDelivery = r.ReadText(index++, "FolioQImport.InvoiceDelivery", "");
ssUser = r.ReadText(index++, "FolioQImport.User", "");
ssInvoice_pdf = r.ReadText(index++, "FolioQImport.Invoice_pdf", "");
ssInvoice_xml = r.ReadText(index++, "FolioQImport.Invoice_xml", "");
ssPep = r.ReadText(index++, "FolioQImport.Pep", "");
ssSite_id = r.ReadText(index++, "FolioQImport.Site_id", "");
ssSite_name = r.ReadText(index++, "FolioQImport.Site_name", "");
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
public void ReadIM(ST_9d31438c744477d5e7fa3ba41ac26dffStructure r) {
this = r;
}


public static bool operator == (ST_9d31438c744477d5e7fa3ba41ac26dffStructure a, ST_9d31438c744477d5e7fa3ba41ac26dffStructure b) {
if (a.ssNumber != b.ssNumber) return false;
if (a.ssOrder != b.ssOrder) return false;
if (a.ssAttachments != b.ssAttachments) return false;
if (a.ssPositions != b.ssPositions) return false;
if (a.ssDelivery_date != b.ssDelivery_date) return false;
if (a.ssInvoiceDelivery != b.ssInvoiceDelivery) return false;
if (a.ssUser != b.ssUser) return false;
if (a.ssInvoice_pdf != b.ssInvoice_pdf) return false;
if (a.ssInvoice_xml != b.ssInvoice_xml) return false;
if (a.ssPep != b.ssPep) return false;
if (a.ssSite_id != b.ssSite_id) return false;
if (a.ssSite_name != b.ssSite_name) return false;
return true;
}

public static bool operator != (ST_9d31438c744477d5e7fa3ba41ac26dffStructure a, ST_9d31438c744477d5e7fa3ba41ac26dffStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_9d31438c744477d5e7fa3ba41ac26dffStructure)) return false;
return (this == (ST_9d31438c744477d5e7fa3ba41ac26dffStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssNumber.GetHashCode()
 ^ ssOrder.GetHashCode()
 ^ ssAttachments.GetHashCode()
 ^ ssPositions.GetHashCode()
 ^ ssDelivery_date.GetHashCode()
 ^ ssInvoiceDelivery.GetHashCode()
 ^ ssUser.GetHashCode()
 ^ ssInvoice_pdf.GetHashCode()
 ^ ssInvoice_xml.GetHashCode()
 ^ ssPep.GetHashCode()
 ^ ssSite_id.GetHashCode()
 ^ ssSite_name.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_9d31438c744477d5e7fa3ba41ac26dffStructure Duplicate() {
ST_9d31438c744477d5e7fa3ba41ac26dffStructure t;
t.ssNumber = this.ssNumber;
t.ssOrder = this.ssOrder;
t.ssAttachments = this.ssAttachments;
t.ssPositions = this.ssPositions;
t.ssDelivery_date = this.ssDelivery_date;
t.ssInvoiceDelivery = this.ssInvoiceDelivery;
t.ssUser = this.ssUser;
t.ssInvoice_pdf = this.ssInvoice_pdf;
t.ssInvoice_xml = this.ssInvoice_xml;
t.ssPep = this.ssPep;
t.ssSite_id = this.ssSite_id;
t.ssSite_name = this.ssSite_name;
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
if (head == "number") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Number")) variable.Value = ssNumber; else variable.Optimized = true;
} else if (head == "order") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Order")) variable.Value = ssOrder; else variable.Optimized = true;
} else if (head == "attachments") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Attachments")) variable.Value = ssAttachments; else variable.Optimized = true;
} else if (head == "positions") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Positions")) variable.Value = ssPositions; else variable.Optimized = true;
} else if (head == "delivery_date") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Delivery_date")) variable.Value = ssDelivery_date; else variable.Optimized = true;
} else if (head == "invoicedelivery") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceDelivery")) variable.Value = ssInvoiceDelivery; else variable.Optimized = true;
} else if (head == "user") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User")) variable.Value = ssUser; else variable.Optimized = true;
} else if (head == "invoice_pdf") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Invoice_pdf")) variable.Value = ssInvoice_pdf; else variable.Optimized = true;
} else if (head == "invoice_xml") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Invoice_xml")) variable.Value = ssInvoice_xml; else variable.Optimized = true;
} else if (head == "pep") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Pep")) variable.Value = ssPep; else variable.Optimized = true;
} else if (head == "site_id") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Site_id")) variable.Value = ssSite_id; else variable.Optimized = true;
} else if (head == "site_name") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Site_name")) variable.Value = ssSite_name; else variable.Optimized = true;
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
if (key == IdNumber) {
return ssNumber;
}
if (key == IdOrder) {
return ssOrder;
}
if (key == IdAttachments) {
return ssAttachments;
}
if (key == IdPositions) {
return ssPositions;
}
if (key == IdDelivery_date) {
return ssDelivery_date;
}
if (key == IdInvoiceDelivery) {
return ssInvoiceDelivery;
}
if (key == IdUser) {
return ssUser;
}
if (key == IdInvoice_pdf) {
return ssInvoice_pdf;
}
if (key == IdInvoice_xml) {
return ssInvoice_xml;
}
if (key == IdPep) {
return ssPep;
}
if (key == IdSite_id) {
return ssSite_id;
}
if (key == IdSite_name) {
return ssSite_name;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdNumber.Key.AsGuid) {
return ssNumber;
}
if (attributeKey == IdOrder.Key.AsGuid) {
return ssOrder;
}
if (attributeKey == IdAttachments.Key.AsGuid) {
return ssAttachments;
}
if (attributeKey == IdPositions.Key.AsGuid) {
return ssPositions;
}
if (attributeKey == IdDelivery_date.Key.AsGuid) {
return ssDelivery_date;
}
if (attributeKey == IdInvoiceDelivery.Key.AsGuid) {
return ssInvoiceDelivery;
}
if (attributeKey == IdUser.Key.AsGuid) {
return ssUser;
}
if (attributeKey == IdInvoice_pdf.Key.AsGuid) {
return ssInvoice_pdf;
}
if (attributeKey == IdInvoice_xml.Key.AsGuid) {
return ssInvoice_xml;
}
if (attributeKey == IdPep.Key.AsGuid) {
return ssPep;
}
if (attributeKey == IdSite_id.Key.AsGuid) {
return ssSite_id;
}
if (attributeKey == IdSite_name.Key.AsGuid) {
return ssSite_name;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssNumber = (string) other.AttributeGet(IdNumber);
ssOrder = (string) other.AttributeGet(IdOrder);
ssAttachments = (string) other.AttributeGet(IdAttachments);
ssPositions = (string) other.AttributeGet(IdPositions);
ssDelivery_date = (string) other.AttributeGet(IdDelivery_date);
ssInvoiceDelivery = (string) other.AttributeGet(IdInvoiceDelivery);
ssUser = (string) other.AttributeGet(IdUser);
ssInvoice_pdf = (string) other.AttributeGet(IdInvoice_pdf);
ssInvoice_xml = (string) other.AttributeGet(IdInvoice_xml);
ssPep = (string) other.AttributeGet(IdPep);
ssSite_id = (string) other.AttributeGet(IdSite_id);
ssSite_name = (string) other.AttributeGet(IdSite_name);
}
} // ST_9d31438c744477d5e7fa3ba41ac26dffStructure
/// <summary>
/// RecordList type <code>FolioQImportList</code> that represents a record list of
///  <code>FolioQImport</code>
/// </summary>
public partial class RL_6ed68b39ecfdb1277afbd92b92be163e : GenericRecordList<ST_9d31438c744477d5e7fa3ba41ac26dffStructure>, IEnumerable, IEnumerator {

protected override ST_9d31438c744477d5e7fa3ba41ac26dffStructure GetElementDefaultValue() {
return new ST_9d31438c744477d5e7fa3ba41ac26dffStructure();
}

public T[] ToArray<T>(Func<ST_9d31438c744477d5e7fa3ba41ac26dffStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_6ed68b39ecfdb1277afbd92b92be163e recordList, Func<ST_9d31438c744477d5e7fa3ba41ac26dffStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_6ed68b39ecfdb1277afbd92b92be163e(ST_9d31438c744477d5e7fa3ba41ac26dffStructure[] array) {
  RL_6ed68b39ecfdb1277afbd92b92be163e result = new RL_6ed68b39ecfdb1277afbd92b92be163e();
result.InnerFromArray(array);
    return result;
}

public static RL_6ed68b39ecfdb1277afbd92b92be163e ToList<T>(T[] array, Func <T, ST_9d31438c744477d5e7fa3ba41ac26dffStructure> converter) {
  RL_6ed68b39ecfdb1277afbd92b92be163e result = new RL_6ed68b39ecfdb1277afbd92b92be163e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_6ed68b39ecfdb1277afbd92b92be163e FromRestList<T>(RestList<T> restList, Func <T, ST_9d31438c744477d5e7fa3ba41ac26dffStructure> converter) {
  RL_6ed68b39ecfdb1277afbd92b92be163e result = new RL_6ed68b39ecfdb1277afbd92b92be163e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_6ed68b39ecfdb1277afbd92b92be163e() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_9d31438c744477d5e7fa3ba41ac26dffStructure> NewList() {
return new RL_6ed68b39ecfdb1277afbd92b92be163e();
}


} // RL_6ed68b39ecfdb1277afbd92b92be163e
}

