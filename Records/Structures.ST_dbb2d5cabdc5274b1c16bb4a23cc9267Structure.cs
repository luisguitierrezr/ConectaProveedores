namespace ssConectaProveedores {
/// <summary>
/// [Structure] ValidationReportItem (OvutJMUMJ060uo83V4Da7g)
///  <code>ST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure</code> that represent
/// s <code>ValidationReportItem</code> <p>Description: </p>
/// </summary>
// Name: ValidationReportItem
public partial struct ST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure : ITypedRecord<ST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure> {
internal static readonly GlobalObjectKey IdPosition = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*YauwxVDuBU+a74BKwUDnYQ");
internal static readonly GlobalObjectKey IdArticle = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*SwnUru8fHUiyEhId8AJI6A");
internal static readonly GlobalObjectKey IdDescription = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*B+R8Y_ZWtEi4xkpWVBxzug");
internal static readonly GlobalObjectKey IdEntryNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*hTu+hetHa0StIj1lq8IuHw");
internal static readonly GlobalObjectKey IdEntryDate = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*B99raq46AkmOzhvQZYfwhw");
internal static readonly GlobalObjectKey IdMaterialCode = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*6bg0lrx6+0yAC1qU75JGLg");
internal static readonly GlobalObjectKey IdQuantity = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*T+wlOZSM9UCam4U20Yd8CA");
internal static readonly GlobalObjectKey IdUnitPrice = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*T+Q96Gh4f0uRS++XzzNDyQ");
internal static readonly GlobalObjectKey IdTotalAmount = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*hWGZsLgosEudouobQR+TZQ");
internal static readonly GlobalObjectKey IdCurrency = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*zLpcREmxEUCM7IllWps4iw");

public int ssPosition;

public string ssArticle;

public string ssDescription;

public int ssEntryNumber;

public DateTime ssEntryDate;

public string ssMaterialCode;

public int ssQuantity;

public string ssUnitPrice;

public string ssTotalAmount;

public string ssCurrency;


public BitArray OptimizedAttributes;

public ST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure() {
OptimizedAttributes = null;
ssPosition = 0;
ssArticle = "";
ssDescription = "";
ssEntryNumber = 0;
ssEntryDate = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
ssMaterialCode = "";
ssQuantity = 0;
ssUnitPrice = "";
ssTotalAmount = "";
ssCurrency = "";
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
ssPosition = r.ReadInteger(index++, "ValidationReportItem.Position", 0);
ssArticle = r.ReadText(index++, "ValidationReportItem.Article", "");
ssDescription = r.ReadText(index++, "ValidationReportItem.Description", "");
ssEntryNumber = r.ReadInteger(index++, "ValidationReportItem.EntryNumber", 0);
ssEntryDate = r.ReadDate(index++, "ValidationReportItem.EntryDate", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssMaterialCode = r.ReadText(index++, "ValidationReportItem.MaterialCode", "");
ssQuantity = r.ReadInteger(index++, "ValidationReportItem.Quantity", 0);
ssUnitPrice = r.ReadText(index++, "ValidationReportItem.UnitPrice", "");
ssTotalAmount = r.ReadText(index++, "ValidationReportItem.TotalAmount", "");
ssCurrency = r.ReadText(index++, "ValidationReportItem.Currency", "");
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
public void ReadIM(ST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure r) {
this = r;
}


public static bool operator == (ST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure a, ST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure b) {
if (a.ssPosition != b.ssPosition) return false;
if (a.ssArticle != b.ssArticle) return false;
if (a.ssDescription != b.ssDescription) return false;
if (a.ssEntryNumber != b.ssEntryNumber) return false;
if (a.ssEntryDate != b.ssEntryDate) return false;
if (a.ssMaterialCode != b.ssMaterialCode) return false;
if (a.ssQuantity != b.ssQuantity) return false;
if (a.ssUnitPrice != b.ssUnitPrice) return false;
if (a.ssTotalAmount != b.ssTotalAmount) return false;
if (a.ssCurrency != b.ssCurrency) return false;
return true;
}

public static bool operator != (ST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure a, ST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure)) return false;
return (this == (ST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssPosition.GetHashCode()
 ^ ssArticle.GetHashCode()
 ^ ssDescription.GetHashCode()
 ^ ssEntryNumber.GetHashCode()
 ^ ssEntryDate.GetHashCode()
 ^ ssMaterialCode.GetHashCode()
 ^ ssQuantity.GetHashCode()
 ^ ssUnitPrice.GetHashCode()
 ^ ssTotalAmount.GetHashCode()
 ^ ssCurrency.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure Duplicate() {
ST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure t;
t.ssPosition = this.ssPosition;
t.ssArticle = this.ssArticle;
t.ssDescription = this.ssDescription;
t.ssEntryNumber = this.ssEntryNumber;
t.ssEntryDate = this.ssEntryDate;
t.ssMaterialCode = this.ssMaterialCode;
t.ssQuantity = this.ssQuantity;
t.ssUnitPrice = this.ssUnitPrice;
t.ssTotalAmount = this.ssTotalAmount;
t.ssCurrency = this.ssCurrency;
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
if (head == "position") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Position")) variable.Value = ssPosition; else variable.Optimized = true;
} else if (head == "article") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Article")) variable.Value = ssArticle; else variable.Optimized = true;
} else if (head == "description") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Description")) variable.Value = ssDescription; else variable.Optimized = true;
} else if (head == "entrynumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EntryNumber")) variable.Value = ssEntryNumber; else variable.Optimized = true;
} else if (head == "entrydate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EntryDate")) variable.Value = ssEntryDate; else variable.Optimized = true;
} else if (head == "materialcode") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MaterialCode")) variable.Value = ssMaterialCode; else variable.Optimized = true;
} else if (head == "quantity") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Quantity")) variable.Value = ssQuantity; else variable.Optimized = true;
} else if (head == "unitprice") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UnitPrice")) variable.Value = ssUnitPrice; else variable.Optimized = true;
} else if (head == "totalamount") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TotalAmount")) variable.Value = ssTotalAmount; else variable.Optimized = true;
} else if (head == "currency") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Currency")) variable.Value = ssCurrency; else variable.Optimized = true;
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
if (key == IdPosition) {
return ssPosition;
}
if (key == IdArticle) {
return ssArticle;
}
if (key == IdDescription) {
return ssDescription;
}
if (key == IdEntryNumber) {
return ssEntryNumber;
}
if (key == IdEntryDate) {
return ssEntryDate;
}
if (key == IdMaterialCode) {
return ssMaterialCode;
}
if (key == IdQuantity) {
return ssQuantity;
}
if (key == IdUnitPrice) {
return ssUnitPrice;
}
if (key == IdTotalAmount) {
return ssTotalAmount;
}
if (key == IdCurrency) {
return ssCurrency;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPosition.Key.AsGuid) {
return ssPosition;
}
if (attributeKey == IdArticle.Key.AsGuid) {
return ssArticle;
}
if (attributeKey == IdDescription.Key.AsGuid) {
return ssDescription;
}
if (attributeKey == IdEntryNumber.Key.AsGuid) {
return ssEntryNumber;
}
if (attributeKey == IdEntryDate.Key.AsGuid) {
return ssEntryDate;
}
if (attributeKey == IdMaterialCode.Key.AsGuid) {
return ssMaterialCode;
}
if (attributeKey == IdQuantity.Key.AsGuid) {
return ssQuantity;
}
if (attributeKey == IdUnitPrice.Key.AsGuid) {
return ssUnitPrice;
}
if (attributeKey == IdTotalAmount.Key.AsGuid) {
return ssTotalAmount;
}
if (attributeKey == IdCurrency.Key.AsGuid) {
return ssCurrency;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssPosition = (int) other.AttributeGet(IdPosition);
ssArticle = (string) other.AttributeGet(IdArticle);
ssDescription = (string) other.AttributeGet(IdDescription);
ssEntryNumber = (int) other.AttributeGet(IdEntryNumber);
ssEntryDate = (DateTime) other.AttributeGet(IdEntryDate);
ssMaterialCode = (string) other.AttributeGet(IdMaterialCode);
ssQuantity = (int) other.AttributeGet(IdQuantity);
ssUnitPrice = (string) other.AttributeGet(IdUnitPrice);
ssTotalAmount = (string) other.AttributeGet(IdTotalAmount);
ssCurrency = (string) other.AttributeGet(IdCurrency);
}
} // ST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure
/// <summary>
/// RecordList type <code>ValidationReportItemList</code> that represents a record list of
///  <code>ValidationReportItem</code>
/// </summary>
public partial class RL_f0441ae281d3bacc0d1d0acaed8c2549 : GenericRecordList<ST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure>, IEnumerable, IEnumerator {

protected override ST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure GetElementDefaultValue() {
return new ST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure();
}

public T[] ToArray<T>(Func<ST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f0441ae281d3bacc0d1d0acaed8c2549 recordList, Func<ST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f0441ae281d3bacc0d1d0acaed8c2549(ST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure[] array) {
  RL_f0441ae281d3bacc0d1d0acaed8c2549 result = new RL_f0441ae281d3bacc0d1d0acaed8c2549();
result.InnerFromArray(array);
    return result;
}

public static RL_f0441ae281d3bacc0d1d0acaed8c2549 ToList<T>(T[] array, Func <T, ST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure> converter) {
  RL_f0441ae281d3bacc0d1d0acaed8c2549 result = new RL_f0441ae281d3bacc0d1d0acaed8c2549();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f0441ae281d3bacc0d1d0acaed8c2549 FromRestList<T>(RestList<T> restList, Func <T, ST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure> converter) {
  RL_f0441ae281d3bacc0d1d0acaed8c2549 result = new RL_f0441ae281d3bacc0d1d0acaed8c2549();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f0441ae281d3bacc0d1d0acaed8c2549() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure> NewList() {
return new RL_f0441ae281d3bacc0d1d0acaed8c2549();
}


} // RL_f0441ae281d3bacc0d1d0acaed8c2549
}

