namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (uAsBBbpUyk6+WqMZYtzJZg)
///  <code>RC_95110bc97f34f4c1561c8cbf2b5015b2</code> that represent
/// s <code>OrderMainItemFolioFolioItemsRecord</code> <p>Description: </p>
/// </summary>
// Name: OrderMainItemFolioFolioItemsRecord
public partial struct RC_95110bc97f34f4c1561c8cbf2b5015b2 : ITypedRecord<RC_95110bc97f34f4c1561c8cbf2b5015b2> {
internal static readonly GlobalObjectKey IdOrderMainItem = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*fyDMxBeQTt4BP6vPHo6+rw");
internal static readonly GlobalObjectKey IdFolio = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+Czrz7YK54PZqbXQLZyVJg");
internal static readonly GlobalObjectKey IdFolioItems = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*tfJh+FJZCU2OCYEVavm3qw");

public EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord ssENOrderMainItem;

public EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord ssENFolio;

public EN_868430b5192a8eb1a739e01247fc2704EntityRecord ssENFolioItems;


public BitArray OptimizedAttributes;

public RC_95110bc97f34f4c1561c8cbf2b5015b2() {
OptimizedAttributes = null;
ssENOrderMainItem = new EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord();
ssENFolio = new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord();
ssENFolioItems = new EN_868430b5192a8eb1a739e01247fc2704EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(51,false);
    all[1] = new BitArray(20,false);
    all[2] = new BitArray(18,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderMainItem.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENFolio.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENFolioItems.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENOrderMainItem.OptimizedAttributes = value[0];
    ssENFolio.OptimizedAttributes = value[1];
    ssENFolioItems.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENOrderMainItem.OptimizedAttributes;
    all[1] = ssENFolio.OptimizedAttributes;
    all[2] = ssENFolioItems.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENOrderMainItem.Read( r, ref index);
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
public void ReadIM(RC_95110bc97f34f4c1561c8cbf2b5015b2 r) {
this = r;
}


public static bool operator == (RC_95110bc97f34f4c1561c8cbf2b5015b2 a, RC_95110bc97f34f4c1561c8cbf2b5015b2 b) {
if (a.ssENOrderMainItem != b.ssENOrderMainItem) return false;
if (a.ssENFolio != b.ssENFolio) return false;
if (a.ssENFolioItems != b.ssENFolioItems) return false;
return true;
}

public static bool operator != (RC_95110bc97f34f4c1561c8cbf2b5015b2 a, RC_95110bc97f34f4c1561c8cbf2b5015b2 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_95110bc97f34f4c1561c8cbf2b5015b2)) return false;
return (this == (RC_95110bc97f34f4c1561c8cbf2b5015b2)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderMainItem.GetHashCode()
 ^ ssENFolio.GetHashCode()
 ^ ssENFolioItems.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderMainItem.RecursiveReset();
ssENFolio.RecursiveReset();
ssENFolioItems.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderMainItem.InternalRecursiveSave();
ssENFolio.InternalRecursiveSave();
ssENFolioItems.InternalRecursiveSave();
}


public RC_95110bc97f34f4c1561c8cbf2b5015b2 Duplicate() {
RC_95110bc97f34f4c1561c8cbf2b5015b2 t;
t.ssENOrderMainItem = (EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord)this.ssENOrderMainItem.Duplicate();
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
if (head == "ordermainitem") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMainItem")) variable.Value = ssENOrderMainItem; else variable.Optimized = true;
variable.SetFieldName("ordermainitem");
} else if (head == "folio") {
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
if (key == IdOrderMainItem) {
return ssENOrderMainItem;
}
if (key == IdFolio) {
return ssENFolio;
}
if (key == IdFolioItems) {
return ssENFolioItems;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderMainItem.Key.AsGuid) {
return ssENOrderMainItem;
}
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
ssENOrderMainItem.FillFromOther((IRecord) other.AttributeGet(IdOrderMainItem));
ssENFolio.FillFromOther((IRecord) other.AttributeGet(IdFolio));
ssENFolioItems.FillFromOther((IRecord) other.AttributeGet(IdFolioItems));
}
} // RC_95110bc97f34f4c1561c8cbf2b5015b2
/// <summary>
/// RecordList type <code>OrderMainItemFolioFolioItemsRecordList</code> that represents a record list
///  of <code>OrderMainItem, Folio, FolioItems</code>
/// </summary>
public partial class RL_a968cf9f63475dc9358672149b11245a : GenericRecordList<RC_95110bc97f34f4c1561c8cbf2b5015b2>, IEnumerable, IEnumerator {

protected override RC_95110bc97f34f4c1561c8cbf2b5015b2 GetElementDefaultValue() {
return new RC_95110bc97f34f4c1561c8cbf2b5015b2();
}

public T[] ToArray<T>(Func<RC_95110bc97f34f4c1561c8cbf2b5015b2, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a968cf9f63475dc9358672149b11245a recordList, Func<RC_95110bc97f34f4c1561c8cbf2b5015b2, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a968cf9f63475dc9358672149b11245a(RC_95110bc97f34f4c1561c8cbf2b5015b2[] array) {
  RL_a968cf9f63475dc9358672149b11245a result = new RL_a968cf9f63475dc9358672149b11245a();
result.InnerFromArray(array);
    return result;
}

public static RL_a968cf9f63475dc9358672149b11245a ToList<T>(T[] array, Func <T, RC_95110bc97f34f4c1561c8cbf2b5015b2> converter) {
  RL_a968cf9f63475dc9358672149b11245a result = new RL_a968cf9f63475dc9358672149b11245a();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a968cf9f63475dc9358672149b11245a FromRestList<T>(RestList<T> restList, Func <T, RC_95110bc97f34f4c1561c8cbf2b5015b2> converter) {
  RL_a968cf9f63475dc9358672149b11245a result = new RL_a968cf9f63475dc9358672149b11245a();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a968cf9f63475dc9358672149b11245a() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(51,false);
def[1] = new BitArray(20,false);
def[2] = new BitArray(18,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_95110bc97f34f4c1561c8cbf2b5015b2> NewList() {
return new RL_a968cf9f63475dc9358672149b11245a();
}


} // RL_a968cf9f63475dc9358672149b11245a
}

