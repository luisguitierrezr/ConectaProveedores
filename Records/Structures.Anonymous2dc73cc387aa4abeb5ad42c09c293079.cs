namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (wzzHLaqHvkq1rULAnCkweQ)
///  <code>RC_3797d4971af6bc97d739ac602330acb1</code> that represent
/// s <code>InvoiceApprovalLevelIdInvoiceIdInvoiceNumberRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceApprovalLevelIdInvoiceIdInvoiceNumberRecord
public partial struct RC_3797d4971af6bc97d739ac602330acb1 : ITypedRecord<RC_3797d4971af6bc97d739ac602330acb1> {
internal static readonly GlobalObjectKey IdInvoiceApprovalLevelId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*DCwQXPo08rxbZl5QxC0f2g");
internal static readonly GlobalObjectKey IdInvoiceId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*FEYfrJuk3IJBHUZHMkXWrA");
internal static readonly GlobalObjectKey IdInvoiceNumber = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*9RWW+oImCT4CH2aTYsM44Q");

public long ssInvoiceApprovalLevelId;

public long ssInvoiceId;

public string ssInvoiceNumber;


public BitArray OptimizedAttributes;

public RC_3797d4971af6bc97d739ac602330acb1() {
OptimizedAttributes = null;
ssInvoiceApprovalLevelId = 0L;
ssInvoiceId = 0L;
ssInvoiceNumber = "";
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
ssInvoiceApprovalLevelId = r.ReadEntityReferenceLongInteger(index++, "InvoiceApprovalLevelIdInvoiceIdInvoiceNumberRecord.InvoiceApprovalLevelId", 0L);
ssInvoiceId = r.ReadEntityReferenceLongInteger(index++, "InvoiceApprovalLevelIdInvoiceIdInvoiceNumberRecord.InvoiceId", 0L);
ssInvoiceNumber = r.ReadText(index++, "InvoiceApprovalLevelIdInvoiceIdInvoiceNumberRecord.InvoiceNumber", "");
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
public void ReadIM(RC_3797d4971af6bc97d739ac602330acb1 r) {
this = r;
}


public static bool operator == (RC_3797d4971af6bc97d739ac602330acb1 a, RC_3797d4971af6bc97d739ac602330acb1 b) {
if (a.ssInvoiceApprovalLevelId != b.ssInvoiceApprovalLevelId) return false;
if (a.ssInvoiceId != b.ssInvoiceId) return false;
if (a.ssInvoiceNumber != b.ssInvoiceNumber) return false;
return true;
}

public static bool operator != (RC_3797d4971af6bc97d739ac602330acb1 a, RC_3797d4971af6bc97d739ac602330acb1 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_3797d4971af6bc97d739ac602330acb1)) return false;
return (this == (RC_3797d4971af6bc97d739ac602330acb1)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssInvoiceApprovalLevelId.GetHashCode()
 ^ ssInvoiceId.GetHashCode()
 ^ ssInvoiceNumber.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_3797d4971af6bc97d739ac602330acb1 Duplicate() {
RC_3797d4971af6bc97d739ac602330acb1 t;
t.ssInvoiceApprovalLevelId = this.ssInvoiceApprovalLevelId;
t.ssInvoiceId = this.ssInvoiceId;
t.ssInvoiceNumber = this.ssInvoiceNumber;
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
if (head == "invoiceapprovallevelid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceApprovalLevelId")) variable.Value = ssInvoiceApprovalLevelId; else variable.Optimized = true;
} else if (head == "invoiceid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceId")) variable.Value = ssInvoiceId; else variable.Optimized = true;
} else if (head == "invoicenumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceNumber")) variable.Value = ssInvoiceNumber; else variable.Optimized = true;
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
if (key == IdInvoiceApprovalLevelId) {
return ssInvoiceApprovalLevelId;
}
if (key == IdInvoiceId) {
return ssInvoiceId;
}
if (key == IdInvoiceNumber) {
return ssInvoiceNumber;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoiceApprovalLevelId.Key.AsGuid) {
return ssInvoiceApprovalLevelId;
}
if (attributeKey == IdInvoiceId.Key.AsGuid) {
return ssInvoiceId;
}
if (attributeKey == IdInvoiceNumber.Key.AsGuid) {
return ssInvoiceNumber;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssInvoiceApprovalLevelId = (long) other.AttributeGet(IdInvoiceApprovalLevelId);
ssInvoiceId = (long) other.AttributeGet(IdInvoiceId);
ssInvoiceNumber = (string) other.AttributeGet(IdInvoiceNumber);
}
} // RC_3797d4971af6bc97d739ac602330acb1
/// <summary>
/// RecordList type <code>InvoiceApprovalLevelIdInvoiceIdInvoiceNumberRecordList</code> that represents
///  a record list of <code>InvoiceApprovalLevelIdentifier, InvoiceIdentifier, Text</code>
/// </summary>
public partial class RL_0bff49813ef08eecaf6190c2661eb115 : GenericRecordList<RC_3797d4971af6bc97d739ac602330acb1>, IEnumerable, IEnumerator {

protected override RC_3797d4971af6bc97d739ac602330acb1 GetElementDefaultValue() {
return new RC_3797d4971af6bc97d739ac602330acb1();
}

public T[] ToArray<T>(Func<RC_3797d4971af6bc97d739ac602330acb1, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_0bff49813ef08eecaf6190c2661eb115 recordList, Func<RC_3797d4971af6bc97d739ac602330acb1, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_0bff49813ef08eecaf6190c2661eb115(RC_3797d4971af6bc97d739ac602330acb1[] array) {
  RL_0bff49813ef08eecaf6190c2661eb115 result = new RL_0bff49813ef08eecaf6190c2661eb115();
result.InnerFromArray(array);
    return result;
}

public static RL_0bff49813ef08eecaf6190c2661eb115 ToList<T>(T[] array, Func <T, RC_3797d4971af6bc97d739ac602330acb1> converter) {
  RL_0bff49813ef08eecaf6190c2661eb115 result = new RL_0bff49813ef08eecaf6190c2661eb115();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_0bff49813ef08eecaf6190c2661eb115 FromRestList<T>(RestList<T> restList, Func <T, RC_3797d4971af6bc97d739ac602330acb1> converter) {
  RL_0bff49813ef08eecaf6190c2661eb115 result = new RL_0bff49813ef08eecaf6190c2661eb115();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_0bff49813ef08eecaf6190c2661eb115() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_3797d4971af6bc97d739ac602330acb1> NewList() {
return new RL_0bff49813ef08eecaf6190c2661eb115();
}


} // RL_0bff49813ef08eecaf6190c2661eb115
}

