namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (ayl8FlCtSUK4yafr10CgqA)
///  <code>RC_53d17e5a9f6c0fdb10660d26c96f84cc</code> that represent
/// s <code>InvoiceExtendedItemInvoiceExtendedRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceExtendedItemInvoiceExtendedRecord
public partial struct RC_53d17e5a9f6c0fdb10660d26c96f84cc : ITypedRecord<RC_53d17e5a9f6c0fdb10660d26c96f84cc> {
internal static readonly GlobalObjectKey IdInvoiceExtendedItem = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*zxAmf18M2K1rp4yQLDHv+g");
internal static readonly GlobalObjectKey IdInvoiceExtended = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*BfHj+9QKT_Og4KFfiKVocw");

public EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord ssENInvoiceExtendedItem;

public EN_f81a3d226103fd013068b8763798067aEntityRecord ssENInvoiceExtended;


public BitArray OptimizedAttributes;

public RC_53d17e5a9f6c0fdb10660d26c96f84cc() {
OptimizedAttributes = null;
ssENInvoiceExtendedItem = new EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord();
ssENInvoiceExtended = new EN_f81a3d226103fd013068b8763798067aEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(8,false);
    all[1] = new BitArray(19,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoiceExtendedItem.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENInvoiceExtended.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENInvoiceExtendedItem.OptimizedAttributes = value[0];
    ssENInvoiceExtended.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENInvoiceExtendedItem.OptimizedAttributes;
    all[1] = ssENInvoiceExtended.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENInvoiceExtendedItem.Read( r, ref index);
ssENInvoiceExtended.Read( r, ref index);
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
public void ReadIM(RC_53d17e5a9f6c0fdb10660d26c96f84cc r) {
this = r;
}


public static bool operator == (RC_53d17e5a9f6c0fdb10660d26c96f84cc a, RC_53d17e5a9f6c0fdb10660d26c96f84cc b) {
if (a.ssENInvoiceExtendedItem != b.ssENInvoiceExtendedItem) return false;
if (a.ssENInvoiceExtended != b.ssENInvoiceExtended) return false;
return true;
}

public static bool operator != (RC_53d17e5a9f6c0fdb10660d26c96f84cc a, RC_53d17e5a9f6c0fdb10660d26c96f84cc b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_53d17e5a9f6c0fdb10660d26c96f84cc)) return false;
return (this == (RC_53d17e5a9f6c0fdb10660d26c96f84cc)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoiceExtendedItem.GetHashCode()
 ^ ssENInvoiceExtended.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoiceExtendedItem.RecursiveReset();
ssENInvoiceExtended.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoiceExtendedItem.InternalRecursiveSave();
ssENInvoiceExtended.InternalRecursiveSave();
}


public RC_53d17e5a9f6c0fdb10660d26c96f84cc Duplicate() {
RC_53d17e5a9f6c0fdb10660d26c96f84cc t;
t.ssENInvoiceExtendedItem = (EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord)this.ssENInvoiceExtendedItem.Duplicate();
t.ssENInvoiceExtended = (EN_f81a3d226103fd013068b8763798067aEntityRecord)this.ssENInvoiceExtended.Duplicate();
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
if (head == "invoiceextendeditem") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceExtendedItem")) variable.Value = ssENInvoiceExtendedItem; else variable.Optimized = true;
variable.SetFieldName("invoiceextendeditem");
} else if (head == "invoiceextended") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceExtended")) variable.Value = ssENInvoiceExtended; else variable.Optimized = true;
variable.SetFieldName("invoiceextended");
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
if (key == IdInvoiceExtendedItem) {
return ssENInvoiceExtendedItem;
}
if (key == IdInvoiceExtended) {
return ssENInvoiceExtended;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoiceExtendedItem.Key.AsGuid) {
return ssENInvoiceExtendedItem;
}
if (attributeKey == IdInvoiceExtended.Key.AsGuid) {
return ssENInvoiceExtended;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoiceExtendedItem.FillFromOther((IRecord) other.AttributeGet(IdInvoiceExtendedItem));
ssENInvoiceExtended.FillFromOther((IRecord) other.AttributeGet(IdInvoiceExtended));
}
} // RC_53d17e5a9f6c0fdb10660d26c96f84cc
/// <summary>
/// RecordList type <code>InvoiceExtendedItemInvoiceExtendedRecordList</code> that represents a record
///  list of <code>InvoiceExtendedItem, InvoiceExtended</code>
/// </summary>
public partial class RL_b41a8c83e4b5ec52d4ddabd5de41d62b : GenericRecordList<RC_53d17e5a9f6c0fdb10660d26c96f84cc>, IEnumerable, IEnumerator {

protected override RC_53d17e5a9f6c0fdb10660d26c96f84cc GetElementDefaultValue() {
return new RC_53d17e5a9f6c0fdb10660d26c96f84cc();
}

public T[] ToArray<T>(Func<RC_53d17e5a9f6c0fdb10660d26c96f84cc, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_b41a8c83e4b5ec52d4ddabd5de41d62b recordList, Func<RC_53d17e5a9f6c0fdb10660d26c96f84cc, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_b41a8c83e4b5ec52d4ddabd5de41d62b(RC_53d17e5a9f6c0fdb10660d26c96f84cc[] array) {
  RL_b41a8c83e4b5ec52d4ddabd5de41d62b result = new RL_b41a8c83e4b5ec52d4ddabd5de41d62b();
result.InnerFromArray(array);
    return result;
}

public static RL_b41a8c83e4b5ec52d4ddabd5de41d62b ToList<T>(T[] array, Func <T, RC_53d17e5a9f6c0fdb10660d26c96f84cc> converter) {
  RL_b41a8c83e4b5ec52d4ddabd5de41d62b result = new RL_b41a8c83e4b5ec52d4ddabd5de41d62b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_b41a8c83e4b5ec52d4ddabd5de41d62b FromRestList<T>(RestList<T> restList, Func <T, RC_53d17e5a9f6c0fdb10660d26c96f84cc> converter) {
  RL_b41a8c83e4b5ec52d4ddabd5de41d62b result = new RL_b41a8c83e4b5ec52d4ddabd5de41d62b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_b41a8c83e4b5ec52d4ddabd5de41d62b() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(8,false);
def[1] = new BitArray(19,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_53d17e5a9f6c0fdb10660d26c96f84cc> NewList() {
return new RL_b41a8c83e4b5ec52d4ddabd5de41d62b();
}


} // RL_b41a8c83e4b5ec52d4ddabd5de41d62b
}

