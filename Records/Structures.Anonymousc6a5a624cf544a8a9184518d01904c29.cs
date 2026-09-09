namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (JKalxlTPikqRhFGNAZBMKQ)
///  <code>RC_88067cef1566b3e5511988d0eaf88bc3</code> that represent
/// s <code>FolioSAPDataOrderMainItemFolioFolioItemsRecord</code> <p>Description: </p>
/// </summary>
// Name: FolioSAPDataOrderMainItemFolioFolioItemsRecord
public partial struct RC_88067cef1566b3e5511988d0eaf88bc3 : ITypedRecord<RC_88067cef1566b3e5511988d0eaf88bc3> {
internal static readonly GlobalObjectKey IdFolioSAPData = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*xIbSf5GGFjMBxQJ1gK5a9Q");
internal static readonly GlobalObjectKey IdOrderMainItem = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*fyDMxBeQTt4BP6vPHo6+rw");
internal static readonly GlobalObjectKey IdFolio = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+Czrz7YK54PZqbXQLZyVJg");
internal static readonly GlobalObjectKey IdFolioItems = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*tfJh+FJZCU2OCYEVavm3qw");

public EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord ssENFolioSAPData;

public EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord ssENOrderMainItem;

public EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord ssENFolio;

public EN_868430b5192a8eb1a739e01247fc2704EntityRecord ssENFolioItems;


public BitArray OptimizedAttributes;

public RC_88067cef1566b3e5511988d0eaf88bc3() {
OptimizedAttributes = null;
ssENFolioSAPData = new EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord();
ssENOrderMainItem = new EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord();
ssENFolio = new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord();
ssENFolioItems = new EN_868430b5192a8eb1a739e01247fc2704EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[4];
    all[0] = new BitArray(15,false);
    all[1] = new BitArray(51,false);
    all[2] = new BitArray(20,false);
    all[3] = new BitArray(18,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENFolioSAPData.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENOrderMainItem.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENFolio.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENFolioItems.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    }else{
    ssENFolioSAPData.OptimizedAttributes = value[0];
    ssENOrderMainItem.OptimizedAttributes = value[1];
    ssENFolio.OptimizedAttributes = value[2];
    ssENFolioItems.OptimizedAttributes = value[3];
    }
}
get{
    BitArray[] all = new BitArray[4];
    all[0] = ssENFolioSAPData.OptimizedAttributes;
    all[1] = ssENOrderMainItem.OptimizedAttributes;
    all[2] = ssENFolio.OptimizedAttributes;
    all[3] = ssENFolioItems.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENFolioSAPData.Read( r, ref index);
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
public void ReadIM(RC_88067cef1566b3e5511988d0eaf88bc3 r) {
this = r;
}


public static bool operator == (RC_88067cef1566b3e5511988d0eaf88bc3 a, RC_88067cef1566b3e5511988d0eaf88bc3 b) {
if (a.ssENFolioSAPData != b.ssENFolioSAPData) return false;
if (a.ssENOrderMainItem != b.ssENOrderMainItem) return false;
if (a.ssENFolio != b.ssENFolio) return false;
if (a.ssENFolioItems != b.ssENFolioItems) return false;
return true;
}

public static bool operator != (RC_88067cef1566b3e5511988d0eaf88bc3 a, RC_88067cef1566b3e5511988d0eaf88bc3 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_88067cef1566b3e5511988d0eaf88bc3)) return false;
return (this == (RC_88067cef1566b3e5511988d0eaf88bc3)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENFolioSAPData.GetHashCode()
 ^ ssENOrderMainItem.GetHashCode()
 ^ ssENFolio.GetHashCode()
 ^ ssENFolioItems.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENFolioSAPData.RecursiveReset();
ssENOrderMainItem.RecursiveReset();
ssENFolio.RecursiveReset();
ssENFolioItems.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENFolioSAPData.InternalRecursiveSave();
ssENOrderMainItem.InternalRecursiveSave();
ssENFolio.InternalRecursiveSave();
ssENFolioItems.InternalRecursiveSave();
}


public RC_88067cef1566b3e5511988d0eaf88bc3 Duplicate() {
RC_88067cef1566b3e5511988d0eaf88bc3 t;
t.ssENFolioSAPData = (EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord)this.ssENFolioSAPData.Duplicate();
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
if (head == "foliosapdata") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioSAPData")) variable.Value = ssENFolioSAPData; else variable.Optimized = true;
variable.SetFieldName("foliosapdata");
} else if (head == "ordermainitem") {
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
if (key == IdFolioSAPData) {
return ssENFolioSAPData;
}
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
if (attributeKey == IdFolioSAPData.Key.AsGuid) {
return ssENFolioSAPData;
}
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
ssENFolioSAPData.FillFromOther((IRecord) other.AttributeGet(IdFolioSAPData));
ssENOrderMainItem.FillFromOther((IRecord) other.AttributeGet(IdOrderMainItem));
ssENFolio.FillFromOther((IRecord) other.AttributeGet(IdFolio));
ssENFolioItems.FillFromOther((IRecord) other.AttributeGet(IdFolioItems));
}
} // RC_88067cef1566b3e5511988d0eaf88bc3
/// <summary>
/// RecordList type <code>FolioSAPDataOrderMainItemFolioFolioItemsRecordList</code> that represents a
///  record list of <code>FolioSAPData, OrderMainItem, Folio, FolioItems</code>
/// </summary>
public partial class RL_2b1ecd74439b838f80b83dd2e3b4dd2a : GenericRecordList<RC_88067cef1566b3e5511988d0eaf88bc3>, IEnumerable, IEnumerator {

protected override RC_88067cef1566b3e5511988d0eaf88bc3 GetElementDefaultValue() {
return new RC_88067cef1566b3e5511988d0eaf88bc3();
}

public T[] ToArray<T>(Func<RC_88067cef1566b3e5511988d0eaf88bc3, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_2b1ecd74439b838f80b83dd2e3b4dd2a recordList, Func<RC_88067cef1566b3e5511988d0eaf88bc3, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_2b1ecd74439b838f80b83dd2e3b4dd2a(RC_88067cef1566b3e5511988d0eaf88bc3[] array) {
  RL_2b1ecd74439b838f80b83dd2e3b4dd2a result = new RL_2b1ecd74439b838f80b83dd2e3b4dd2a();
result.InnerFromArray(array);
    return result;
}

public static RL_2b1ecd74439b838f80b83dd2e3b4dd2a ToList<T>(T[] array, Func <T, RC_88067cef1566b3e5511988d0eaf88bc3> converter) {
  RL_2b1ecd74439b838f80b83dd2e3b4dd2a result = new RL_2b1ecd74439b838f80b83dd2e3b4dd2a();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_2b1ecd74439b838f80b83dd2e3b4dd2a FromRestList<T>(RestList<T> restList, Func <T, RC_88067cef1566b3e5511988d0eaf88bc3> converter) {
  RL_2b1ecd74439b838f80b83dd2e3b4dd2a result = new RL_2b1ecd74439b838f80b83dd2e3b4dd2a();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_2b1ecd74439b838f80b83dd2e3b4dd2a() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[4];
def[0] = new BitArray(15,false);
def[1] = new BitArray(51,false);
def[2] = new BitArray(20,false);
def[3] = new BitArray(18,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_88067cef1566b3e5511988d0eaf88bc3> NewList() {
return new RL_2b1ecd74439b838f80b83dd2e3b4dd2a();
}


} // RL_2b1ecd74439b838f80b83dd2e3b4dd2a
}

