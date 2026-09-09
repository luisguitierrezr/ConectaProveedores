namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (9uEDQ15J8Emuam7XpnWqcQ)
///  <code>RC_6fe7a87544f5e670c064f35599cfc737</code> that represent
/// s <code>CodeIdClassDescriptionLabelOrderNumberOrderDateCountTotalAmountRecord</code>
///  <p>Description: </p>
/// </summary>
// Name: CodeIdClassDescriptionLabelOrderNumberOrderDateCountTotalAmountRecord
public partial struct RC_6fe7a87544f5e670c064f35599cfc737 : ITypedRecord<RC_6fe7a87544f5e670c064f35599cfc737> {
internal static readonly GlobalObjectKey IdCode = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*yt4VRP4RkEyoGZ5KbAPRjg");
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*evg51goEc9xcUB8w19ZXMw");
internal static readonly GlobalObjectKey IdClass = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*C32bcVYbnYI8kDesUHHrOQ");
internal static readonly GlobalObjectKey IdDescription = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*LjJZK8tMkdS7XE_ByZkY+g");
internal static readonly GlobalObjectKey IdLabel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*yCwB2Ehb5xiK6wqWGgpcpg");
internal static readonly GlobalObjectKey IdOrderNumber = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*wAa0qxge8G_KWh0b4rJCyg");
internal static readonly GlobalObjectKey IdOrderDate = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*z_MVJGAq4pYRcnd_3E6BRQ");
internal static readonly GlobalObjectKey IdCount = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Hf+xdpZqUjewQd_vPxy4NQ");
internal static readonly GlobalObjectKey IdTotalAmount = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*hGfezG6Xz67BwALXklWiZA");

public string ssCode;

public long ssId;

public string ssClass;

public string ssDescription;

public string ssLabel;

public string ssOrderNumber;

public DateTime ssOrderDate;

public long ssCount;

public decimal ssTotalAmount;


public BitArray OptimizedAttributes;

public RC_6fe7a87544f5e670c064f35599cfc737() {
OptimizedAttributes = null;
ssCode = "";
ssId = 0L;
ssClass = "";
ssDescription = "";
ssLabel = "";
ssOrderNumber = "";
ssOrderDate = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
ssCount = 0L;
ssTotalAmount = 0.0M;
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
ssCode = r.ReadEntityReferenceText(index++, "CodeIdClassDescriptionLabelOrderNumberOrderDateCountTotalAmountRecord.Code", "");
ssId = r.ReadEntityReferenceLongInteger(index++, "CodeIdClassDescriptionLabelOrderNumberOrderDateCountTotalAmountRecord.Id", 0L);
ssClass = r.ReadText(index++, "CodeIdClassDescriptionLabelOrderNumberOrderDateCountTotalAmountRecord.Class", "");
ssDescription = r.ReadText(index++, "CodeIdClassDescriptionLabelOrderNumberOrderDateCountTotalAmountRecord.Description", "");
ssLabel = r.ReadText(index++, "CodeIdClassDescriptionLabelOrderNumberOrderDateCountTotalAmountRecord.Label", "");
ssOrderNumber = r.ReadText(index++, "CodeIdClassDescriptionLabelOrderNumberOrderDateCountTotalAmountRecord.OrderNumber", "");
ssOrderDate = r.ReadDate(index++, "CodeIdClassDescriptionLabelOrderNumberOrderDateCountTotalAmountRecord.OrderDate", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssCount = r.ReadLongInteger(index++, "CodeIdClassDescriptionLabelOrderNumberOrderDateCountTotalAmountRecord.Count", 0L);
ssTotalAmount = r.ReadCurrency(index++, "CodeIdClassDescriptionLabelOrderNumberOrderDateCountTotalAmountRecord.TotalAmount", 0.0M);
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
public void ReadIM(RC_6fe7a87544f5e670c064f35599cfc737 r) {
this = r;
}


public static bool operator == (RC_6fe7a87544f5e670c064f35599cfc737 a, RC_6fe7a87544f5e670c064f35599cfc737 b) {
if (a.ssCode != b.ssCode) return false;
if (a.ssId != b.ssId) return false;
if (a.ssClass != b.ssClass) return false;
if (a.ssDescription != b.ssDescription) return false;
if (a.ssLabel != b.ssLabel) return false;
if (a.ssOrderNumber != b.ssOrderNumber) return false;
if (a.ssOrderDate != b.ssOrderDate) return false;
if (a.ssCount != b.ssCount) return false;
if (a.ssTotalAmount != b.ssTotalAmount) return false;
return true;
}

public static bool operator != (RC_6fe7a87544f5e670c064f35599cfc737 a, RC_6fe7a87544f5e670c064f35599cfc737 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_6fe7a87544f5e670c064f35599cfc737)) return false;
return (this == (RC_6fe7a87544f5e670c064f35599cfc737)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssCode.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssClass.GetHashCode()
 ^ ssDescription.GetHashCode()
 ^ ssLabel.GetHashCode()
 ^ ssOrderNumber.GetHashCode()
 ^ ssOrderDate.GetHashCode()
 ^ ssCount.GetHashCode()
 ^ ssTotalAmount.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_6fe7a87544f5e670c064f35599cfc737 Duplicate() {
RC_6fe7a87544f5e670c064f35599cfc737 t;
t.ssCode = this.ssCode;
t.ssId = this.ssId;
t.ssClass = this.ssClass;
t.ssDescription = this.ssDescription;
t.ssLabel = this.ssLabel;
t.ssOrderNumber = this.ssOrderNumber;
t.ssOrderDate = this.ssOrderDate;
t.ssCount = this.ssCount;
t.ssTotalAmount = this.ssTotalAmount;
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
if (head == "code") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Code")) variable.Value = ssCode; else variable.Optimized = true;
} else if (head == "id") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Id")) variable.Value = ssId; else variable.Optimized = true;
} else if (head == "class") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Class")) variable.Value = ssClass; else variable.Optimized = true;
} else if (head == "description") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Description")) variable.Value = ssDescription; else variable.Optimized = true;
} else if (head == "label") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Label")) variable.Value = ssLabel; else variable.Optimized = true;
} else if (head == "ordernumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderNumber")) variable.Value = ssOrderNumber; else variable.Optimized = true;
} else if (head == "orderdate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderDate")) variable.Value = ssOrderDate; else variable.Optimized = true;
} else if (head == "count") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Count")) variable.Value = ssCount; else variable.Optimized = true;
} else if (head == "totalamount") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TotalAmount")) variable.Value = ssTotalAmount; else variable.Optimized = true;
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
if (key == IdCode) {
return ssCode;
}
if (key == IdId) {
return ssId;
}
if (key == IdClass) {
return ssClass;
}
if (key == IdDescription) {
return ssDescription;
}
if (key == IdLabel) {
return ssLabel;
}
if (key == IdOrderNumber) {
return ssOrderNumber;
}
if (key == IdOrderDate) {
return ssOrderDate;
}
if (key == IdCount) {
return ssCount;
}
if (key == IdTotalAmount) {
return ssTotalAmount;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCode.Key.AsGuid) {
return ssCode;
}
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdClass.Key.AsGuid) {
return ssClass;
}
if (attributeKey == IdDescription.Key.AsGuid) {
return ssDescription;
}
if (attributeKey == IdLabel.Key.AsGuid) {
return ssLabel;
}
if (attributeKey == IdOrderNumber.Key.AsGuid) {
return ssOrderNumber;
}
if (attributeKey == IdOrderDate.Key.AsGuid) {
return ssOrderDate;
}
if (attributeKey == IdCount.Key.AsGuid) {
return ssCount;
}
if (attributeKey == IdTotalAmount.Key.AsGuid) {
return ssTotalAmount;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssCode = (string) other.AttributeGet(IdCode);
ssId = (long) other.AttributeGet(IdId);
ssClass = (string) other.AttributeGet(IdClass);
ssDescription = (string) other.AttributeGet(IdDescription);
ssLabel = (string) other.AttributeGet(IdLabel);
ssOrderNumber = (string) other.AttributeGet(IdOrderNumber);
ssOrderDate = (DateTime) other.AttributeGet(IdOrderDate);
ssCount = (long) other.AttributeGet(IdCount);
ssTotalAmount = (decimal) other.AttributeGet(IdTotalAmount);
}
} // RC_6fe7a87544f5e670c064f35599cfc737
/// <summary>
/// RecordList type
///  <code>CodeIdClassDescriptionLabelOrderNumberOrderDateCountTotalAmountRecordList</code> tha
/// t represents a record list of <code>CurrencyIdentifier, OrderMainIdentifier, Text, Text, Text,
///  Text, Date, LongInteger, Currency</code>
/// </summary>
public partial class RL_ef17ec11e9847e3aee2e73d3f7420983 : GenericRecordList<RC_6fe7a87544f5e670c064f35599cfc737>, IEnumerable, IEnumerator {

protected override RC_6fe7a87544f5e670c064f35599cfc737 GetElementDefaultValue() {
return new RC_6fe7a87544f5e670c064f35599cfc737();
}

public T[] ToArray<T>(Func<RC_6fe7a87544f5e670c064f35599cfc737, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ef17ec11e9847e3aee2e73d3f7420983 recordList, Func<RC_6fe7a87544f5e670c064f35599cfc737, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ef17ec11e9847e3aee2e73d3f7420983(RC_6fe7a87544f5e670c064f35599cfc737[] array) {
  RL_ef17ec11e9847e3aee2e73d3f7420983 result = new RL_ef17ec11e9847e3aee2e73d3f7420983();
result.InnerFromArray(array);
    return result;
}

public static RL_ef17ec11e9847e3aee2e73d3f7420983 ToList<T>(T[] array, Func <T, RC_6fe7a87544f5e670c064f35599cfc737> converter) {
  RL_ef17ec11e9847e3aee2e73d3f7420983 result = new RL_ef17ec11e9847e3aee2e73d3f7420983();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ef17ec11e9847e3aee2e73d3f7420983 FromRestList<T>(RestList<T> restList, Func <T, RC_6fe7a87544f5e670c064f35599cfc737> converter) {
  RL_ef17ec11e9847e3aee2e73d3f7420983 result = new RL_ef17ec11e9847e3aee2e73d3f7420983();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ef17ec11e9847e3aee2e73d3f7420983() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_6fe7a87544f5e670c064f35599cfc737> NewList() {
return new RL_ef17ec11e9847e3aee2e73d3f7420983();
}


} // RL_ef17ec11e9847e3aee2e73d3f7420983
}

