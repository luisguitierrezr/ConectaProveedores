namespace ssConectaProveedores {
/// <summary>
/// [Structure] DocumentExtrationOutput (8lRBTQkFOEekHjZf9qcVPw)
///  <code>ST_37a6487c1fae199ee92f583d495139beStructure</code> that represent
/// s <code>DocumentExtrationOutput</code> <p>Description: </p>
/// </summary>
// Name: DocumentExtrationOutput
public partial struct ST_37a6487c1fae199ee92f583d495139beStructure : ITypedRecord<ST_37a6487c1fae199ee92f583d495139beStructure> {
internal static readonly GlobalObjectKey IdSelect = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*mLzZ8_hcpUiV0nAAGkSBZw");
internal static readonly GlobalObjectKey IdSupplierName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*SBAB2FFVQUOJl33FCTOe8Q");
internal static readonly GlobalObjectKey IdInvoiceName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*gHEb1phMJUejBarXtJJnjQ");
internal static readonly GlobalObjectKey IdRequisitionName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*_e+1lx1a4UW8gSWEIu4V_g");
internal static readonly GlobalObjectKey IdTotalAmount = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*aGUfHbj1JkuYUonIaGczuQ");
internal static readonly GlobalObjectKey IdCurrency = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*PeE7QIq03UiZXmhX8FQiZg");
internal static readonly GlobalObjectKey IdUUId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*_J9Lwk83e06PaaPsxrl1Yg");
internal static readonly GlobalObjectKey IdFilename = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*qziJin2ydUKdu9ai82kGPw");
internal static readonly GlobalObjectKey IdCreateOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*edMvSNDVu0iJYBad8CEVCw");
internal static readonly GlobalObjectKey IdAccountDate = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*sHe2vxyed0G2d5IGbTxl+g");
internal static readonly GlobalObjectKey IdStorageId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*AovTNXNs7k6TLBM5Q2i21Q");
internal static readonly GlobalObjectKey IdSize = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*lGdEW1Th9EWMqSsHqSPtMQ");

public bool ssSelect;

public string ssSupplierName;

public string ssInvoiceName;

public string ssRequisitionName;

public decimal ssTotalAmount;

public string ssCurrency;

public string ssUUId;

public string ssFilename;

public DateTime ssCreateOn;

public DateTime ssAccountDate;

public long ssStorageId;

public long ssSize;


public BitArray OptimizedAttributes;

public ST_37a6487c1fae199ee92f583d495139beStructure() {
OptimizedAttributes = null;
ssSelect = false;
ssSupplierName = "";
ssInvoiceName = "";
ssRequisitionName = "";
ssTotalAmount = 0.0M;
ssCurrency = "";
ssUUId = "";
ssFilename = "";
ssCreateOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
ssAccountDate = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
ssStorageId = 0L;
ssSize = 0L;
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
ssSelect = r.ReadBoolean(index++, "DocumentExtrationOutput.Select", false);
ssSupplierName = r.ReadText(index++, "DocumentExtrationOutput.SupplierName", "");
ssInvoiceName = r.ReadText(index++, "DocumentExtrationOutput.InvoiceName", "");
ssRequisitionName = r.ReadText(index++, "DocumentExtrationOutput.RequisitionName", "");
ssTotalAmount = r.ReadDecimal(index++, "DocumentExtrationOutput.TotalAmount", 0.0M);
ssCurrency = r.ReadText(index++, "DocumentExtrationOutput.Currency", "");
ssUUId = r.ReadText(index++, "DocumentExtrationOutput.UUId", "");
ssFilename = r.ReadText(index++, "DocumentExtrationOutput.Filename", "");
ssCreateOn = r.ReadDateTime(index++, "DocumentExtrationOutput.CreateOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssAccountDate = r.ReadDate(index++, "DocumentExtrationOutput.AccountDate", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssStorageId = r.ReadEntityReferenceLongInteger(index++, "DocumentExtrationOutput.StorageId", 0L);
ssSize = r.ReadLongInteger(index++, "DocumentExtrationOutput.Size", 0L);
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
public void ReadIM(ST_37a6487c1fae199ee92f583d495139beStructure r) {
this = r;
}


public static bool operator == (ST_37a6487c1fae199ee92f583d495139beStructure a, ST_37a6487c1fae199ee92f583d495139beStructure b) {
if (a.ssSelect != b.ssSelect) return false;
if (a.ssSupplierName != b.ssSupplierName) return false;
if (a.ssInvoiceName != b.ssInvoiceName) return false;
if (a.ssRequisitionName != b.ssRequisitionName) return false;
if (a.ssTotalAmount != b.ssTotalAmount) return false;
if (a.ssCurrency != b.ssCurrency) return false;
if (a.ssUUId != b.ssUUId) return false;
if (a.ssFilename != b.ssFilename) return false;
if (a.ssCreateOn != b.ssCreateOn) return false;
if (a.ssAccountDate != b.ssAccountDate) return false;
if (a.ssStorageId != b.ssStorageId) return false;
if (a.ssSize != b.ssSize) return false;
return true;
}

public static bool operator != (ST_37a6487c1fae199ee92f583d495139beStructure a, ST_37a6487c1fae199ee92f583d495139beStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_37a6487c1fae199ee92f583d495139beStructure)) return false;
return (this == (ST_37a6487c1fae199ee92f583d495139beStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSelect.GetHashCode()
 ^ ssSupplierName.GetHashCode()
 ^ ssInvoiceName.GetHashCode()
 ^ ssRequisitionName.GetHashCode()
 ^ ssTotalAmount.GetHashCode()
 ^ ssCurrency.GetHashCode()
 ^ ssUUId.GetHashCode()
 ^ ssFilename.GetHashCode()
 ^ ssCreateOn.GetHashCode()
 ^ ssAccountDate.GetHashCode()
 ^ ssStorageId.GetHashCode()
 ^ ssSize.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_37a6487c1fae199ee92f583d495139beStructure Duplicate() {
ST_37a6487c1fae199ee92f583d495139beStructure t;
t.ssSelect = this.ssSelect;
t.ssSupplierName = this.ssSupplierName;
t.ssInvoiceName = this.ssInvoiceName;
t.ssRequisitionName = this.ssRequisitionName;
t.ssTotalAmount = this.ssTotalAmount;
t.ssCurrency = this.ssCurrency;
t.ssUUId = this.ssUUId;
t.ssFilename = this.ssFilename;
t.ssCreateOn = this.ssCreateOn;
t.ssAccountDate = this.ssAccountDate;
t.ssStorageId = this.ssStorageId;
t.ssSize = this.ssSize;
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
if (head == "select") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Select")) variable.Value = ssSelect; else variable.Optimized = true;
} else if (head == "suppliername") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SupplierName")) variable.Value = ssSupplierName; else variable.Optimized = true;
} else if (head == "invoicename") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceName")) variable.Value = ssInvoiceName; else variable.Optimized = true;
} else if (head == "requisitionname") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionName")) variable.Value = ssRequisitionName; else variable.Optimized = true;
} else if (head == "totalamount") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TotalAmount")) variable.Value = ssTotalAmount; else variable.Optimized = true;
} else if (head == "currency") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Currency")) variable.Value = ssCurrency; else variable.Optimized = true;
} else if (head == "uuid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UUId")) variable.Value = ssUUId; else variable.Optimized = true;
} else if (head == "filename") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Filename")) variable.Value = ssFilename; else variable.Optimized = true;
} else if (head == "createon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreateOn")) variable.Value = ssCreateOn; else variable.Optimized = true;
} else if (head == "accountdate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AccountDate")) variable.Value = ssAccountDate; else variable.Optimized = true;
} else if (head == "storageid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".StorageId")) variable.Value = ssStorageId; else variable.Optimized = true;
} else if (head == "size") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Size")) variable.Value = ssSize; else variable.Optimized = true;
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
if (key == IdSelect) {
return ssSelect;
}
if (key == IdSupplierName) {
return ssSupplierName;
}
if (key == IdInvoiceName) {
return ssInvoiceName;
}
if (key == IdRequisitionName) {
return ssRequisitionName;
}
if (key == IdTotalAmount) {
return ssTotalAmount;
}
if (key == IdCurrency) {
return ssCurrency;
}
if (key == IdUUId) {
return ssUUId;
}
if (key == IdFilename) {
return ssFilename;
}
if (key == IdCreateOn) {
return ssCreateOn;
}
if (key == IdAccountDate) {
return ssAccountDate;
}
if (key == IdStorageId) {
return ssStorageId;
}
if (key == IdSize) {
return ssSize;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSelect.Key.AsGuid) {
return ssSelect;
}
if (attributeKey == IdSupplierName.Key.AsGuid) {
return ssSupplierName;
}
if (attributeKey == IdInvoiceName.Key.AsGuid) {
return ssInvoiceName;
}
if (attributeKey == IdRequisitionName.Key.AsGuid) {
return ssRequisitionName;
}
if (attributeKey == IdTotalAmount.Key.AsGuid) {
return ssTotalAmount;
}
if (attributeKey == IdCurrency.Key.AsGuid) {
return ssCurrency;
}
if (attributeKey == IdUUId.Key.AsGuid) {
return ssUUId;
}
if (attributeKey == IdFilename.Key.AsGuid) {
return ssFilename;
}
if (attributeKey == IdCreateOn.Key.AsGuid) {
return ssCreateOn;
}
if (attributeKey == IdAccountDate.Key.AsGuid) {
return ssAccountDate;
}
if (attributeKey == IdStorageId.Key.AsGuid) {
return ssStorageId;
}
if (attributeKey == IdSize.Key.AsGuid) {
return ssSize;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSelect = (bool) other.AttributeGet(IdSelect);
ssSupplierName = (string) other.AttributeGet(IdSupplierName);
ssInvoiceName = (string) other.AttributeGet(IdInvoiceName);
ssRequisitionName = (string) other.AttributeGet(IdRequisitionName);
ssTotalAmount = (decimal) other.AttributeGet(IdTotalAmount);
ssCurrency = (string) other.AttributeGet(IdCurrency);
ssUUId = (string) other.AttributeGet(IdUUId);
ssFilename = (string) other.AttributeGet(IdFilename);
ssCreateOn = (DateTime) other.AttributeGet(IdCreateOn);
ssAccountDate = (DateTime) other.AttributeGet(IdAccountDate);
ssStorageId = (long) other.AttributeGet(IdStorageId);
ssSize = (long) other.AttributeGet(IdSize);
}
} // ST_37a6487c1fae199ee92f583d495139beStructure
/// <summary>
/// RecordList type <code>DocumentExtrationOutputList</code> that represents a record list of
///  <code>DocumentExtrationOutput</code>
/// </summary>
public partial class RL_4236ffd993178ba431a66b30d7460972 : GenericRecordList<ST_37a6487c1fae199ee92f583d495139beStructure>, IEnumerable, IEnumerator {

protected override ST_37a6487c1fae199ee92f583d495139beStructure GetElementDefaultValue() {
return new ST_37a6487c1fae199ee92f583d495139beStructure();
}

public T[] ToArray<T>(Func<ST_37a6487c1fae199ee92f583d495139beStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_4236ffd993178ba431a66b30d7460972 recordList, Func<ST_37a6487c1fae199ee92f583d495139beStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_4236ffd993178ba431a66b30d7460972(ST_37a6487c1fae199ee92f583d495139beStructure[] array) {
  RL_4236ffd993178ba431a66b30d7460972 result = new RL_4236ffd993178ba431a66b30d7460972();
result.InnerFromArray(array);
    return result;
}

public static RL_4236ffd993178ba431a66b30d7460972 ToList<T>(T[] array, Func <T, ST_37a6487c1fae199ee92f583d495139beStructure> converter) {
  RL_4236ffd993178ba431a66b30d7460972 result = new RL_4236ffd993178ba431a66b30d7460972();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_4236ffd993178ba431a66b30d7460972 FromRestList<T>(RestList<T> restList, Func <T, ST_37a6487c1fae199ee92f583d495139beStructure> converter) {
  RL_4236ffd993178ba431a66b30d7460972 result = new RL_4236ffd993178ba431a66b30d7460972();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_4236ffd993178ba431a66b30d7460972() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_37a6487c1fae199ee92f583d495139beStructure> NewList() {
return new RL_4236ffd993178ba431a66b30d7460972();
}


} // RL_4236ffd993178ba431a66b30d7460972
}

