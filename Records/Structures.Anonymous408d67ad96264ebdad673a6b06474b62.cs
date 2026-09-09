namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (rWeNQCaWvU6tZzprBkdLYg)
///  <code>RC_d1d085a826d7afd1d542eed60c39554c</code> that represents <code>FolioSupplierRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: FolioSupplierRecord
public partial struct RC_d1d085a826d7afd1d542eed60c39554c : ITypedRecord<RC_d1d085a826d7afd1d542eed60c39554c> {
internal static readonly GlobalObjectKey IdFolio = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+Czrz7YK54PZqbXQLZyVJg");
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dOw0SWrcY4B7hMCYX1sSzg");

public EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord ssENFolio;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier;


public BitArray OptimizedAttributes;

public RC_d1d085a826d7afd1d542eed60c39554c() {
OptimizedAttributes = null;
ssENFolio = new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord();
ssENSupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(20,false);
    all[1] = new BitArray(28,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENFolio.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENSupplier.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENFolio.OptimizedAttributes = value[0];
    ssENSupplier.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENFolio.OptimizedAttributes;
    all[1] = ssENSupplier.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENFolio.Read( r, ref index);
ssENSupplier.Read( r, ref index);
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
public void ReadIM(RC_d1d085a826d7afd1d542eed60c39554c r) {
this = r;
}


public static bool operator == (RC_d1d085a826d7afd1d542eed60c39554c a, RC_d1d085a826d7afd1d542eed60c39554c b) {
if (a.ssENFolio != b.ssENFolio) return false;
if (a.ssENSupplier != b.ssENSupplier) return false;
return true;
}

public static bool operator != (RC_d1d085a826d7afd1d542eed60c39554c a, RC_d1d085a826d7afd1d542eed60c39554c b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_d1d085a826d7afd1d542eed60c39554c)) return false;
return (this == (RC_d1d085a826d7afd1d542eed60c39554c)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENFolio.GetHashCode()
 ^ ssENSupplier.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENFolio.RecursiveReset();
ssENSupplier.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENFolio.InternalRecursiveSave();
ssENSupplier.InternalRecursiveSave();
}


public RC_d1d085a826d7afd1d542eed60c39554c Duplicate() {
RC_d1d085a826d7afd1d542eed60c39554c t;
t.ssENFolio = (EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord)this.ssENFolio.Duplicate();
t.ssENSupplier = (EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord)this.ssENSupplier.Duplicate();
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
if (head == "folio") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Folio")) variable.Value = ssENFolio; else variable.Optimized = true;
variable.SetFieldName("folio");
} else if (head == "supplier") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Supplier")) variable.Value = ssENSupplier; else variable.Optimized = true;
variable.SetFieldName("supplier");
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
if (key == IdFolio) {
return ssENFolio;
}
if (key == IdSupplier) {
return ssENSupplier;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFolio.Key.AsGuid) {
return ssENFolio;
}
if (attributeKey == IdSupplier.Key.AsGuid) {
return ssENSupplier;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENFolio.FillFromOther((IRecord) other.AttributeGet(IdFolio));
ssENSupplier.FillFromOther((IRecord) other.AttributeGet(IdSupplier));
}
} // RC_d1d085a826d7afd1d542eed60c39554c
/// <summary>
/// RecordList type <code>FolioSupplierRecordList</code> that represents a record list of <code>Folio,
///  Supplier</code>
/// </summary>
public partial class RL_8d8af94fcd9af501b3964ae58f9c81aa : GenericRecordList<RC_d1d085a826d7afd1d542eed60c39554c>, IEnumerable, IEnumerator {

protected override RC_d1d085a826d7afd1d542eed60c39554c GetElementDefaultValue() {
return new RC_d1d085a826d7afd1d542eed60c39554c();
}

public T[] ToArray<T>(Func<RC_d1d085a826d7afd1d542eed60c39554c, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_8d8af94fcd9af501b3964ae58f9c81aa recordList, Func<RC_d1d085a826d7afd1d542eed60c39554c, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_8d8af94fcd9af501b3964ae58f9c81aa(RC_d1d085a826d7afd1d542eed60c39554c[] array) {
  RL_8d8af94fcd9af501b3964ae58f9c81aa result = new RL_8d8af94fcd9af501b3964ae58f9c81aa();
result.InnerFromArray(array);
    return result;
}

public static RL_8d8af94fcd9af501b3964ae58f9c81aa ToList<T>(T[] array, Func <T, RC_d1d085a826d7afd1d542eed60c39554c> converter) {
  RL_8d8af94fcd9af501b3964ae58f9c81aa result = new RL_8d8af94fcd9af501b3964ae58f9c81aa();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_8d8af94fcd9af501b3964ae58f9c81aa FromRestList<T>(RestList<T> restList, Func <T, RC_d1d085a826d7afd1d542eed60c39554c> converter) {
  RL_8d8af94fcd9af501b3964ae58f9c81aa result = new RL_8d8af94fcd9af501b3964ae58f9c81aa();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_8d8af94fcd9af501b3964ae58f9c81aa() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(20,false);
def[1] = new BitArray(28,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_d1d085a826d7afd1d542eed60c39554c> NewList() {
return new RL_8d8af94fcd9af501b3964ae58f9c81aa();
}


} // RL_8d8af94fcd9af501b3964ae58f9c81aa
}

