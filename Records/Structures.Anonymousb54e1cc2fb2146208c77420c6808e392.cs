namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (whxOtSH7IEaMd0IMaAjjkg)
///  <code>RC_c81aee5ce0504fe68694be6deb703b5e</code> that represents <code>SupplierRegionRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: SupplierRegionRecord
public partial struct RC_c81aee5ce0504fe68694be6deb703b5e : ITypedRecord<RC_c81aee5ce0504fe68694be6deb703b5e> {
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dOw0SWrcY4B7hMCYX1sSzg");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w1243kBmkvqNrl3ySTBl0A");

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion;


public BitArray OptimizedAttributes;

public RC_c81aee5ce0504fe68694be6deb703b5e() {
OptimizedAttributes = null;
ssENSupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
ssENRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(28,false);
    all[1] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENSupplier.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENRegion.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENSupplier.OptimizedAttributes = value[0];
    ssENRegion.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENSupplier.OptimizedAttributes;
    all[1] = ssENRegion.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENSupplier.Read( r, ref index);
ssENRegion.Read( r, ref index);
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
public void ReadIM(RC_c81aee5ce0504fe68694be6deb703b5e r) {
this = r;
}


public static bool operator == (RC_c81aee5ce0504fe68694be6deb703b5e a, RC_c81aee5ce0504fe68694be6deb703b5e b) {
if (a.ssENSupplier != b.ssENSupplier) return false;
if (a.ssENRegion != b.ssENRegion) return false;
return true;
}

public static bool operator != (RC_c81aee5ce0504fe68694be6deb703b5e a, RC_c81aee5ce0504fe68694be6deb703b5e b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_c81aee5ce0504fe68694be6deb703b5e)) return false;
return (this == (RC_c81aee5ce0504fe68694be6deb703b5e)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENSupplier.GetHashCode()
 ^ ssENRegion.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENSupplier.RecursiveReset();
ssENRegion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENSupplier.InternalRecursiveSave();
ssENRegion.InternalRecursiveSave();
}


public RC_c81aee5ce0504fe68694be6deb703b5e Duplicate() {
RC_c81aee5ce0504fe68694be6deb703b5e t;
t.ssENSupplier = (EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord)this.ssENSupplier.Duplicate();
t.ssENRegion = (EN_31f501c551d210017fcb34b5237e3390EntityRecord)this.ssENRegion.Duplicate();
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
if (!VarValue.FieldIsOptimized(parent, baseName + ".Supplier")) variable.Value = ssENSupplier; else variable.Optimized = true;
variable.SetFieldName("supplier");
} else if (head == "region") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Region")) variable.Value = ssENRegion; else variable.Optimized = true;
variable.SetFieldName("region");
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
return ssENSupplier;
}
if (key == IdRegion) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSupplier.Key.AsGuid) {
return ssENSupplier;
}
if (attributeKey == IdRegion.Key.AsGuid) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENSupplier.FillFromOther((IRecord) other.AttributeGet(IdSupplier));
ssENRegion.FillFromOther((IRecord) other.AttributeGet(IdRegion));
}
} // RC_c81aee5ce0504fe68694be6deb703b5e
/// <summary>
/// RecordList type <code>SupplierRegionRecordList</code> that represents a record list of
///  <code>Supplier, Region</code>
/// </summary>
public partial class RL_f647e8c4990b814587d1a017e4c9dd44 : GenericRecordList<RC_c81aee5ce0504fe68694be6deb703b5e>, IEnumerable, IEnumerator {

protected override RC_c81aee5ce0504fe68694be6deb703b5e GetElementDefaultValue() {
return new RC_c81aee5ce0504fe68694be6deb703b5e();
}

public T[] ToArray<T>(Func<RC_c81aee5ce0504fe68694be6deb703b5e, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f647e8c4990b814587d1a017e4c9dd44 recordList, Func<RC_c81aee5ce0504fe68694be6deb703b5e, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f647e8c4990b814587d1a017e4c9dd44(RC_c81aee5ce0504fe68694be6deb703b5e[] array) {
  RL_f647e8c4990b814587d1a017e4c9dd44 result = new RL_f647e8c4990b814587d1a017e4c9dd44();
result.InnerFromArray(array);
    return result;
}

public static RL_f647e8c4990b814587d1a017e4c9dd44 ToList<T>(T[] array, Func <T, RC_c81aee5ce0504fe68694be6deb703b5e> converter) {
  RL_f647e8c4990b814587d1a017e4c9dd44 result = new RL_f647e8c4990b814587d1a017e4c9dd44();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f647e8c4990b814587d1a017e4c9dd44 FromRestList<T>(RestList<T> restList, Func <T, RC_c81aee5ce0504fe68694be6deb703b5e> converter) {
  RL_f647e8c4990b814587d1a017e4c9dd44 result = new RL_f647e8c4990b814587d1a017e4c9dd44();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f647e8c4990b814587d1a017e4c9dd44() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(28,false);
def[1] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_c81aee5ce0504fe68694be6deb703b5e> NewList() {
return new RL_f647e8c4990b814587d1a017e4c9dd44();
}


} // RL_f647e8c4990b814587d1a017e4c9dd44
}

