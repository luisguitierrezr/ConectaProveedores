namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (2UyQdVf5VUyfjZlMjVxLHA)
///  <code>RC_a7662588f9e72f6305013b985632ea24</code> that represents <code>FolioFolioItemsRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: FolioFolioItemsRecord
public partial struct RC_a7662588f9e72f6305013b985632ea24 : ITypedRecord<RC_a7662588f9e72f6305013b985632ea24> {
internal static readonly GlobalObjectKey IdFolio = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+Czrz7YK54PZqbXQLZyVJg");
internal static readonly GlobalObjectKey IdFolioItems = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*tfJh+FJZCU2OCYEVavm3qw");

public EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord ssENFolio;

public EN_868430b5192a8eb1a739e01247fc2704EntityRecord ssENFolioItems;


public BitArray OptimizedAttributes;

public RC_a7662588f9e72f6305013b985632ea24() {
OptimizedAttributes = null;
ssENFolio = new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord();
ssENFolioItems = new EN_868430b5192a8eb1a739e01247fc2704EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(20,false);
    all[1] = new BitArray(18,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENFolio.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENFolioItems.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENFolio.OptimizedAttributes = value[0];
    ssENFolioItems.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENFolio.OptimizedAttributes;
    all[1] = ssENFolioItems.OptimizedAttributes;
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
ssENFolioItems.Read( r, ref index);
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
public void ReadIM(RC_a7662588f9e72f6305013b985632ea24 r) {
this = r;
}


public static bool operator == (RC_a7662588f9e72f6305013b985632ea24 a, RC_a7662588f9e72f6305013b985632ea24 b) {
if (a.ssENFolio != b.ssENFolio) return false;
if (a.ssENFolioItems != b.ssENFolioItems) return false;
return true;
}

public static bool operator != (RC_a7662588f9e72f6305013b985632ea24 a, RC_a7662588f9e72f6305013b985632ea24 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_a7662588f9e72f6305013b985632ea24)) return false;
return (this == (RC_a7662588f9e72f6305013b985632ea24)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENFolio.GetHashCode()
 ^ ssENFolioItems.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENFolio.RecursiveReset();
ssENFolioItems.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENFolio.InternalRecursiveSave();
ssENFolioItems.InternalRecursiveSave();
}


public RC_a7662588f9e72f6305013b985632ea24 Duplicate() {
RC_a7662588f9e72f6305013b985632ea24 t;
t.ssENFolio = (EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord)this.ssENFolio.Duplicate();
t.ssENFolioItems = (EN_868430b5192a8eb1a739e01247fc2704EntityRecord)this.ssENFolioItems.Duplicate();
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
} else if (head == "folioitems") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioItems")) variable.Value = ssENFolioItems; else variable.Optimized = true;
variable.SetFieldName("folioitems");
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
if (key == IdFolioItems) {
return ssENFolioItems;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFolio.Key.AsGuid) {
return ssENFolio;
}
if (attributeKey == IdFolioItems.Key.AsGuid) {
return ssENFolioItems;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENFolio.FillFromOther((IRecord) other.AttributeGet(IdFolio));
ssENFolioItems.FillFromOther((IRecord) other.AttributeGet(IdFolioItems));
}
} // RC_a7662588f9e72f6305013b985632ea24
/// <summary>
/// RecordList type <code>FolioFolioItemsRecordList</code> that represents a record list of
///  <code>Folio, FolioItems</code>
/// </summary>
public partial class RL_78938401e31bd787b9997c7622522571 : GenericRecordList<RC_a7662588f9e72f6305013b985632ea24>, IEnumerable, IEnumerator {

protected override RC_a7662588f9e72f6305013b985632ea24 GetElementDefaultValue() {
return new RC_a7662588f9e72f6305013b985632ea24();
}

public T[] ToArray<T>(Func<RC_a7662588f9e72f6305013b985632ea24, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_78938401e31bd787b9997c7622522571 recordList, Func<RC_a7662588f9e72f6305013b985632ea24, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_78938401e31bd787b9997c7622522571(RC_a7662588f9e72f6305013b985632ea24[] array) {
  RL_78938401e31bd787b9997c7622522571 result = new RL_78938401e31bd787b9997c7622522571();
result.InnerFromArray(array);
    return result;
}

public static RL_78938401e31bd787b9997c7622522571 ToList<T>(T[] array, Func <T, RC_a7662588f9e72f6305013b985632ea24> converter) {
  RL_78938401e31bd787b9997c7622522571 result = new RL_78938401e31bd787b9997c7622522571();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_78938401e31bd787b9997c7622522571 FromRestList<T>(RestList<T> restList, Func <T, RC_a7662588f9e72f6305013b985632ea24> converter) {
  RL_78938401e31bd787b9997c7622522571 result = new RL_78938401e31bd787b9997c7622522571();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_78938401e31bd787b9997c7622522571() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(20,false);
def[1] = new BitArray(18,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_a7662588f9e72f6305013b985632ea24> NewList() {
return new RL_78938401e31bd787b9997c7622522571();
}


} // RL_78938401e31bd787b9997c7622522571
}

