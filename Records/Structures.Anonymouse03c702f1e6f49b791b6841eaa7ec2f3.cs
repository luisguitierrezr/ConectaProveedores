namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (L3A84G8et0mRtoQeqn7C8w)
///  <code>RC_b6257dfb536e679f8b7be7b4b56f189b</code> that represent
/// s <code>InvoiceInvoiceExtendedRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceInvoiceExtendedRecord
public partial struct RC_b6257dfb536e679f8b7be7b4b56f189b : ITypedRecord<RC_b6257dfb536e679f8b7be7b4b56f189b> {
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdInvoiceExtended = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*BfHj+9QKT_Og4KFfiKVocw");

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_f81a3d226103fd013068b8763798067aEntityRecord ssENInvoiceExtended;


public BitArray OptimizedAttributes;

public RC_b6257dfb536e679f8b7be7b4b56f189b() {
OptimizedAttributes = null;
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENInvoiceExtended = new EN_f81a3d226103fd013068b8763798067aEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(24,false);
    all[1] = new BitArray(19,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENInvoiceExtended.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENInvoice.OptimizedAttributes = value[0];
    ssENInvoiceExtended.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENInvoice.OptimizedAttributes;
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
ssENInvoice.Read( r, ref index);
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
public void ReadIM(RC_b6257dfb536e679f8b7be7b4b56f189b r) {
this = r;
}


public static bool operator == (RC_b6257dfb536e679f8b7be7b4b56f189b a, RC_b6257dfb536e679f8b7be7b4b56f189b b) {
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENInvoiceExtended != b.ssENInvoiceExtended) return false;
return true;
}

public static bool operator != (RC_b6257dfb536e679f8b7be7b4b56f189b a, RC_b6257dfb536e679f8b7be7b4b56f189b b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_b6257dfb536e679f8b7be7b4b56f189b)) return false;
return (this == (RC_b6257dfb536e679f8b7be7b4b56f189b)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENInvoiceExtended.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoice.RecursiveReset();
ssENInvoiceExtended.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoice.InternalRecursiveSave();
ssENInvoiceExtended.InternalRecursiveSave();
}


public RC_b6257dfb536e679f8b7be7b4b56f189b Duplicate() {
RC_b6257dfb536e679f8b7be7b4b56f189b t;
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
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
if (head == "invoice") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Invoice")) variable.Value = ssENInvoice; else variable.Optimized = true;
variable.SetFieldName("invoice");
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
if (key == IdInvoice) {
return ssENInvoice;
}
if (key == IdInvoiceExtended) {
return ssENInvoiceExtended;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoice.Key.AsGuid) {
return ssENInvoice;
}
if (attributeKey == IdInvoiceExtended.Key.AsGuid) {
return ssENInvoiceExtended;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoice.FillFromOther((IRecord) other.AttributeGet(IdInvoice));
ssENInvoiceExtended.FillFromOther((IRecord) other.AttributeGet(IdInvoiceExtended));
}
} // RC_b6257dfb536e679f8b7be7b4b56f189b
/// <summary>
/// RecordList type <code>InvoiceInvoiceExtendedRecordList</code> that represents a record list of
///  <code>Invoice, InvoiceExtended</code>
/// </summary>
public partial class RL_1f9a243d40703326d9bf7c63586316cd : GenericRecordList<RC_b6257dfb536e679f8b7be7b4b56f189b>, IEnumerable, IEnumerator {

protected override RC_b6257dfb536e679f8b7be7b4b56f189b GetElementDefaultValue() {
return new RC_b6257dfb536e679f8b7be7b4b56f189b();
}

public T[] ToArray<T>(Func<RC_b6257dfb536e679f8b7be7b4b56f189b, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_1f9a243d40703326d9bf7c63586316cd recordList, Func<RC_b6257dfb536e679f8b7be7b4b56f189b, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_1f9a243d40703326d9bf7c63586316cd(RC_b6257dfb536e679f8b7be7b4b56f189b[] array) {
  RL_1f9a243d40703326d9bf7c63586316cd result = new RL_1f9a243d40703326d9bf7c63586316cd();
result.InnerFromArray(array);
    return result;
}

public static RL_1f9a243d40703326d9bf7c63586316cd ToList<T>(T[] array, Func <T, RC_b6257dfb536e679f8b7be7b4b56f189b> converter) {
  RL_1f9a243d40703326d9bf7c63586316cd result = new RL_1f9a243d40703326d9bf7c63586316cd();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_1f9a243d40703326d9bf7c63586316cd FromRestList<T>(RestList<T> restList, Func <T, RC_b6257dfb536e679f8b7be7b4b56f189b> converter) {
  RL_1f9a243d40703326d9bf7c63586316cd result = new RL_1f9a243d40703326d9bf7c63586316cd();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_1f9a243d40703326d9bf7c63586316cd() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(24,false);
def[1] = new BitArray(19,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_b6257dfb536e679f8b7be7b4b56f189b> NewList() {
return new RL_1f9a243d40703326d9bf7c63586316cd();
}


} // RL_1f9a243d40703326d9bf7c63586316cd
}

