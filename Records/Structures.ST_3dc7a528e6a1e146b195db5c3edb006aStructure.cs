namespace ssConectaProveedores {
/// <summary>
/// [Structure] FolioScreenTableStructure (16eM_az8pkmQDYZ6fgA0Eg)
///  <code>ST_3dc7a528e6a1e146b195db5c3edb006aStructure</code> that represent
/// s <code>FolioScreenTableStructure</code> <p>Description: </p>
/// </summary>
// Name: FolioScreenTableStructure
public partial struct ST_3dc7a528e6a1e146b195db5c3edb006aStructure : ITypedRecord<ST_3dc7a528e6a1e146b195db5c3edb006aStructure> {
internal static readonly GlobalObjectKey IdFolioId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Fo4F647FE0G3ozQXcu4dzQ");
internal static readonly GlobalObjectKey IdFolioNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*uxwzrE8YnEWA9QXYNfAV9w");
internal static readonly GlobalObjectKey IdOrderNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*3VsqUuEbrkqIoswPSEecyg");
internal static readonly GlobalObjectKey IdSupplierName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ZFVV2sJRC0y5sIxVApBsEg");
internal static readonly GlobalObjectKey IdSupplierNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*fXxPxAQqnUG6izRbhCLWdA");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*edUmFfdqPEKoZthlNY24yQ");
internal static readonly GlobalObjectKey IdTotalAmount = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*FGo1dPSsZ06AAKfYtkFh8A");
internal static readonly GlobalObjectKey IdCurrency = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*0BdmsJUiiEGmTmEdCAKmIA");
internal static readonly GlobalObjectKey IdUploadDate = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*hSPSgYkA3U2qKmECtrLkBw");
internal static readonly GlobalObjectKey IdStatus = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*rZ6ppk2CEUuRs5YgSg47Zw");

public long ssFolioId;

public string ssFolioNumber;

public string ssOrderNumber;

public string ssSupplierName;

public string ssSupplierNumber;

public string ssRegion;

public string ssTotalAmount;

public string ssCurrency;

public string ssUploadDate;

public string ssStatus;


public BitArray OptimizedAttributes;

public ST_3dc7a528e6a1e146b195db5c3edb006aStructure() {
OptimizedAttributes = null;
ssFolioId = 0L;
ssFolioNumber = "";
ssOrderNumber = "";
ssSupplierName = "";
ssSupplierNumber = "";
ssRegion = "";
ssTotalAmount = "";
ssCurrency = "";
ssUploadDate = "";
ssStatus = "";
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
ssFolioId = r.ReadEntityReferenceLongInteger(index++, "FolioScreenTableStructure.FolioId", 0L);
ssFolioNumber = r.ReadText(index++, "FolioScreenTableStructure.FolioNumber", "");
ssOrderNumber = r.ReadText(index++, "FolioScreenTableStructure.OrderNumber", "");
ssSupplierName = r.ReadText(index++, "FolioScreenTableStructure.SupplierName", "");
ssSupplierNumber = r.ReadText(index++, "FolioScreenTableStructure.SupplierNumber", "");
ssRegion = r.ReadText(index++, "FolioScreenTableStructure.Region", "");
ssTotalAmount = r.ReadText(index++, "FolioScreenTableStructure.TotalAmount", "");
ssCurrency = r.ReadText(index++, "FolioScreenTableStructure.Currency", "");
ssUploadDate = r.ReadText(index++, "FolioScreenTableStructure.UploadDate", "");
ssStatus = r.ReadText(index++, "FolioScreenTableStructure.Status", "");
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
public void ReadIM(ST_3dc7a528e6a1e146b195db5c3edb006aStructure r) {
this = r;
}


public static bool operator == (ST_3dc7a528e6a1e146b195db5c3edb006aStructure a, ST_3dc7a528e6a1e146b195db5c3edb006aStructure b) {
if (a.ssFolioId != b.ssFolioId) return false;
if (a.ssFolioNumber != b.ssFolioNumber) return false;
if (a.ssOrderNumber != b.ssOrderNumber) return false;
if (a.ssSupplierName != b.ssSupplierName) return false;
if (a.ssSupplierNumber != b.ssSupplierNumber) return false;
if (a.ssRegion != b.ssRegion) return false;
if (a.ssTotalAmount != b.ssTotalAmount) return false;
if (a.ssCurrency != b.ssCurrency) return false;
if (a.ssUploadDate != b.ssUploadDate) return false;
if (a.ssStatus != b.ssStatus) return false;
return true;
}

public static bool operator != (ST_3dc7a528e6a1e146b195db5c3edb006aStructure a, ST_3dc7a528e6a1e146b195db5c3edb006aStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_3dc7a528e6a1e146b195db5c3edb006aStructure)) return false;
return (this == (ST_3dc7a528e6a1e146b195db5c3edb006aStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssFolioId.GetHashCode()
 ^ ssFolioNumber.GetHashCode()
 ^ ssOrderNumber.GetHashCode()
 ^ ssSupplierName.GetHashCode()
 ^ ssSupplierNumber.GetHashCode()
 ^ ssRegion.GetHashCode()
 ^ ssTotalAmount.GetHashCode()
 ^ ssCurrency.GetHashCode()
 ^ ssUploadDate.GetHashCode()
 ^ ssStatus.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_3dc7a528e6a1e146b195db5c3edb006aStructure Duplicate() {
ST_3dc7a528e6a1e146b195db5c3edb006aStructure t;
t.ssFolioId = this.ssFolioId;
t.ssFolioNumber = this.ssFolioNumber;
t.ssOrderNumber = this.ssOrderNumber;
t.ssSupplierName = this.ssSupplierName;
t.ssSupplierNumber = this.ssSupplierNumber;
t.ssRegion = this.ssRegion;
t.ssTotalAmount = this.ssTotalAmount;
t.ssCurrency = this.ssCurrency;
t.ssUploadDate = this.ssUploadDate;
t.ssStatus = this.ssStatus;
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
if (head == "folioid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioId")) variable.Value = ssFolioId; else variable.Optimized = true;
} else if (head == "folionumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioNumber")) variable.Value = ssFolioNumber; else variable.Optimized = true;
} else if (head == "ordernumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderNumber")) variable.Value = ssOrderNumber; else variable.Optimized = true;
} else if (head == "suppliername") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SupplierName")) variable.Value = ssSupplierName; else variable.Optimized = true;
} else if (head == "suppliernumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SupplierNumber")) variable.Value = ssSupplierNumber; else variable.Optimized = true;
} else if (head == "region") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Region")) variable.Value = ssRegion; else variable.Optimized = true;
} else if (head == "totalamount") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TotalAmount")) variable.Value = ssTotalAmount; else variable.Optimized = true;
} else if (head == "currency") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Currency")) variable.Value = ssCurrency; else variable.Optimized = true;
} else if (head == "uploaddate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UploadDate")) variable.Value = ssUploadDate; else variable.Optimized = true;
} else if (head == "status") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Status")) variable.Value = ssStatus; else variable.Optimized = true;
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
if (key == IdFolioId) {
return ssFolioId;
}
if (key == IdFolioNumber) {
return ssFolioNumber;
}
if (key == IdOrderNumber) {
return ssOrderNumber;
}
if (key == IdSupplierName) {
return ssSupplierName;
}
if (key == IdSupplierNumber) {
return ssSupplierNumber;
}
if (key == IdRegion) {
return ssRegion;
}
if (key == IdTotalAmount) {
return ssTotalAmount;
}
if (key == IdCurrency) {
return ssCurrency;
}
if (key == IdUploadDate) {
return ssUploadDate;
}
if (key == IdStatus) {
return ssStatus;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFolioId.Key.AsGuid) {
return ssFolioId;
}
if (attributeKey == IdFolioNumber.Key.AsGuid) {
return ssFolioNumber;
}
if (attributeKey == IdOrderNumber.Key.AsGuid) {
return ssOrderNumber;
}
if (attributeKey == IdSupplierName.Key.AsGuid) {
return ssSupplierName;
}
if (attributeKey == IdSupplierNumber.Key.AsGuid) {
return ssSupplierNumber;
}
if (attributeKey == IdRegion.Key.AsGuid) {
return ssRegion;
}
if (attributeKey == IdTotalAmount.Key.AsGuid) {
return ssTotalAmount;
}
if (attributeKey == IdCurrency.Key.AsGuid) {
return ssCurrency;
}
if (attributeKey == IdUploadDate.Key.AsGuid) {
return ssUploadDate;
}
if (attributeKey == IdStatus.Key.AsGuid) {
return ssStatus;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssFolioId = (long) other.AttributeGet(IdFolioId);
ssFolioNumber = (string) other.AttributeGet(IdFolioNumber);
ssOrderNumber = (string) other.AttributeGet(IdOrderNumber);
ssSupplierName = (string) other.AttributeGet(IdSupplierName);
ssSupplierNumber = (string) other.AttributeGet(IdSupplierNumber);
ssRegion = (string) other.AttributeGet(IdRegion);
ssTotalAmount = (string) other.AttributeGet(IdTotalAmount);
ssCurrency = (string) other.AttributeGet(IdCurrency);
ssUploadDate = (string) other.AttributeGet(IdUploadDate);
ssStatus = (string) other.AttributeGet(IdStatus);
}
} // ST_3dc7a528e6a1e146b195db5c3edb006aStructure
/// <summary>
/// RecordList type <code>FolioScreenTableStructureList</code> that represents a record list of
///  <code>FolioScreenTableStructure</code>
/// </summary>
public partial class RL_9046748205310553b4766e7b1bf0c997 : GenericRecordList<ST_3dc7a528e6a1e146b195db5c3edb006aStructure>, IEnumerable, IEnumerator {

protected override ST_3dc7a528e6a1e146b195db5c3edb006aStructure GetElementDefaultValue() {
return new ST_3dc7a528e6a1e146b195db5c3edb006aStructure();
}

public T[] ToArray<T>(Func<ST_3dc7a528e6a1e146b195db5c3edb006aStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_9046748205310553b4766e7b1bf0c997 recordList, Func<ST_3dc7a528e6a1e146b195db5c3edb006aStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_9046748205310553b4766e7b1bf0c997(ST_3dc7a528e6a1e146b195db5c3edb006aStructure[] array) {
  RL_9046748205310553b4766e7b1bf0c997 result = new RL_9046748205310553b4766e7b1bf0c997();
result.InnerFromArray(array);
    return result;
}

public static RL_9046748205310553b4766e7b1bf0c997 ToList<T>(T[] array, Func <T, ST_3dc7a528e6a1e146b195db5c3edb006aStructure> converter) {
  RL_9046748205310553b4766e7b1bf0c997 result = new RL_9046748205310553b4766e7b1bf0c997();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_9046748205310553b4766e7b1bf0c997 FromRestList<T>(RestList<T> restList, Func <T, ST_3dc7a528e6a1e146b195db5c3edb006aStructure> converter) {
  RL_9046748205310553b4766e7b1bf0c997 result = new RL_9046748205310553b4766e7b1bf0c997();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_9046748205310553b4766e7b1bf0c997() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_3dc7a528e6a1e146b195db5c3edb006aStructure> NewList() {
return new RL_9046748205310553b4766e7b1bf0c997();
}


} // RL_9046748205310553b4766e7b1bf0c997
}

